using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Service;

namespace FazendaUrbana
{
    public partial class FrmSupplierUC : UserControl
    {
        SupplierService SupplierService = new SupplierService();
        AddressService AddressService = new AddressService();
        ContactService ContactService = new ContactService();

        public FrmSupplierUC()
        {
            InitializeComponent();
            supplierBindingSource.DataSource = new Supplier();
            addressBindingSource.DataSource = new Address();
            contactBindingSource.DataSource = new Contact();

            radioButton1.Focus();

            supplierBindingSource1.DataSource = SupplierService.GetAll();

            var listCountry = new List<string>() { "Brasil" };
            countryComboBox.DataSource = listCountry;

            var listState = new List<string>() { "SP" };
            stateCbx.DataSource = listState;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var supplier = supplierBindingSource.Current as Supplier ?? new Supplier();
            var address = addressBindingSource.Current as Address ?? new Address();
            var contact = contactBindingSource.Current as Contact ?? new Contact();

            ValidateFields(supplier, address, contact);

            if (errorProvider1.HasErrors)
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(addressIdTxt.Text) && !string.IsNullOrWhiteSpace(contactIdTxt.Text) && !string.IsNullOrWhiteSpace(supplierIdTxt.Text))
            {
                address.Id = Convert.ToInt32(addressIdTxt.Text);
                contact.Id = Convert.ToInt32(contactIdTxt.Text);
                supplier.Id = Convert.ToInt32(supplierIdTxt.Text);
            }

            var success = SupplierService.Save(supplier, address, contact);
            if (!success)
            {
                MessageBox.Show("Falha ao salvar as alterações!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearFields();

            supplierBindingSource1.DataSource = SupplierService.GetAll();

            MessageBox.Show("Alterações salvas com sucesso!");
        }

        /// <summary>
        /// A edição da tela utiliza os dados do supplierGridView da linha selecionada pelo usuário, preenchendo os dados nos seus respectivos TextBox
        /// <para>Este método também busca as informações de endereço e contato para preenchimento na tela</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!SupplierService.GetAll().Any())
            {
                MessageBox.Show("Não existem dados para serem editados, por favor cadastre um fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = supplierGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a edição, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = supplierGridView.Rows[rowIndex];
            supplierIdTxt.Text = row.Cells[0].Value.ToString(); // ID
            nameTxt.Text = row.Cells[1].Value.ToString(); // Name
            tradeNameTxt.Text = row.Cells[2].Value.ToString(); // TradeName
            companyNameTxt.Text = row.Cells[3].Value.ToString(); // CompanyName
            taxIdTextBox.Text = row.Cells[4].Value.ToString(); // TaxId
            var TypePerson = taxIdTextBox.Text.Replace("/", "").Replace(".", "").Replace("-", "").Length == 11 ? "physical" : "juridical";
            if (TypePerson == "physical")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            addressIdTxt.Text = row.Cells[5].Value.ToString(); // AddressId
            contactIdTxt.Text = row.Cells[6].Value.ToString(); // ContactId

            if (!string.IsNullOrWhiteSpace(addressIdTxt.Text) && !string.IsNullOrWhiteSpace(contactIdTxt.Text))
            {
                var address = AddressService.GetById(Convert.ToInt32(addressIdTxt.Text));
                var contact = ContactService.GetById(Convert.ToInt32(contactIdTxt.Text));

                FillAddressFields(address);
                FillContactFields(contact);
            }
        }

        /// <summary>
        /// Preenche os campos TextBox de endereço
        /// </summary>
        /// <param name="address"></param>
        private void FillAddressFields(Address address)
        {
            countryComboBox.Text = address.Country;
            zipCodeTxt.Text = address.ZipCode;
            cityTxt.Text = address.City;
            stateCbx.Text = address.State;
            streetTxt.Text = address.Street;
            neighborhoodTxt.Text = address.Neighborhood;
            numberTxt.Text = address.Number;
            complementTxt.Text = address.Complement;
        }

        /// <summary>
        /// Preenche os campos TextBox de contato
        /// </summary>
        /// <param name="contact"></param>
        private void FillContactFields(Contact contact)
        {
            phoneTxt.Text = contact.Phone;
            emailTxt.Text = contact.Email;
        }

        /// <summary>
        /// Limpa todos os campos da tela
        /// </summary>
        private void ClearFields()
        {
            supplierBindingSource.DataSource = new Supplier();
            addressBindingSource.DataSource = new Address();
            contactBindingSource.DataSource = new Contact();
            addressIdTxt.Text = string.Empty;
            contactIdTxt.Text = string.Empty;
            supplierIdTxt.Text = string.Empty;
        }

        /// <summary>
        /// Valida a obrigatoriedade dos campos do formulário, setando erro no errorProvider1 se não forem válidos
        /// <para>O errorProvider1 exibe erros nos campos da tela</para>
        /// </summary>
        /// <param name="supplier"></param>
        /// <param name="address"></param>
        /// <param name="contact"></param>
        private void ValidateFields(Supplier supplier, Address address, Contact contact)
        {
            errorProvider1.Clear(); // Clear para sempre limpar os erros antes de checar novamente
            var message = "Campo obrigatório";

            if (string.IsNullOrWhiteSpace(supplier.Name))
            {
                errorProvider1.SetError(nameTxt, message);
            }

            if (string.IsNullOrWhiteSpace(supplier.TradeName))
            {
                errorProvider1.SetError(tradeNameTxt, message);
            }

            if (string.IsNullOrWhiteSpace(supplier.CompanyName))
            {
                errorProvider1.SetError(companyNameTxt, message);
            }

            if (string.IsNullOrWhiteSpace(supplier.TaxId))
            {
                errorProvider1.SetError(taxIdTextBox, message);
            }

            if (string.IsNullOrWhiteSpace(address.Country))
            {
                errorProvider1.SetError(countryComboBox, message);
            }

            if (string.IsNullOrWhiteSpace(address.City))
            {
                errorProvider1.SetError(cityTxt, message);
            }

            if (string.IsNullOrWhiteSpace(address.State))
            {
                errorProvider1.SetError(stateCbx, message);
            }

            if (string.IsNullOrWhiteSpace(address.ZipCode))
            {
                errorProvider1.SetError(zipCodeTxt, message);
            }

            if (string.IsNullOrWhiteSpace(address.Number))
            {
                errorProvider1.SetError(numberTxt, message);
            }

            if (string.IsNullOrWhiteSpace(address.Complement))
            {
                errorProvider1.SetError(complementTxt, message);
            }

            if (string.IsNullOrWhiteSpace(address.Street))
            {
                errorProvider1.SetError(streetTxt, message);
            }

            if (string.IsNullOrWhiteSpace(address.Neighborhood))
            {
                errorProvider1.SetError(neighborhoodTxt, message);
            }

            if (string.IsNullOrWhiteSpace(contact.Phone))
            {
                errorProvider1.SetError(phoneTxt, message);
            }

            if (string.IsNullOrWhiteSpace(contact.Email))
            {
                errorProvider1.SetError(emailTxt, message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            taxIdTextBox.ReadOnly = false;
            taxIdTextBox.Mask = @"000\.000\.000\-00";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            taxIdTextBox.ReadOnly = false;
            taxIdTextBox.Mask = @"00\.000\.000\/0000\-00";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = supplierGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a deleção, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = supplierGridView.Rows[rowIndex];
            var supplierId = Convert.ToInt32(row.Cells[0].Value); // ID

            var success = SupplierService.Delete(supplierId);
            if (!success)
            {
                MessageBox.Show("Erro ao deletar o registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            supplierBindingSource1.DataSource = SupplierService.GetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var supplier = supplierBindingSource.Current as Supplier ?? new Supplier();
            var lstSupplier = SupplierService.GetAll();
            var lstSupplierTemporary = new List<Supplier>();

            if (!string.IsNullOrWhiteSpace(supplier.Name))
            {
                lstSupplierTemporary = lstSupplier.FindAll(p => p.Name.ToUpper().Contains(supplier.Name.ToUpper()));
            }

            if (!lstSupplierTemporary.Any())
            {
                supplierBindingSource1.DataSource = SupplierService.GetAll();
                MessageBox.Show("Não foram encontrados registros com os filtros selecionados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            supplierBindingSource1.DataSource = lstSupplierTemporary;
        }
    }
}