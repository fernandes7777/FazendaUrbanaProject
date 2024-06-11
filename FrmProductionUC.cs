using FazendaUrbana.Forms.Enum;
using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Service;

namespace FazendaUrbana
{
    public partial class FrmProductionUC : UserControl
    {
        ProductionService ProductionService = new ProductionService();

        public FrmProductionUC()
        {
            InitializeComponent();
            productionBindingSource.DataSource = new Production();

            currentSateCbx.DataSource = EnumsList.GetCurrentStateEnum();
            currentSateCbx.DisplayMember = "Description";
            currentSateCbx.ValueMember = "Enum";

            productionBindingSourceGridView.DataSource = ProductionService.GetAll();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var production = productionBindingSource.Current as Production ?? new Production();

            ValidateFields(production);

            if (errorProvider1.HasErrors)
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(productionIdTxt.Text))
            {
                production.Id = Convert.ToInt32(productionIdTxt.Text);
            }

            var success = ProductionService.Save(production);
            if (!success)
            {
                MessageBox.Show("Falha ao salvar as alterações!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearFields();

            productionBindingSourceGridView.DataSource = ProductionService.GetAll();

            MessageBox.Show("Alterações salvas com sucesso!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!ProductionService.GetAll().Any())
            {
                MessageBox.Show("Não existem dados para serem editados, por favor cadastre um registro de produção!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = productionDataGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a edição, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = productionDataGridView.Rows[rowIndex];
            productionIdTxt.Text = row.Cells[0].Value.ToString(); // ID
            initialDateTxt.Text = row.Cells[1].Value.ToString(); // StartDate
            finalDateTxt.Text = row.Cells[2].Value.ToString(); // FinalDate
            locationTxt.Text = row.Cells[3].Value.ToString(); // Location
            methodTxt.Text = row.Cells[4].Value.ToString(); // ProductionMethod
            currentSateCbx.SelectedText = row.Cells[5].Value.ToString(); // CurrentState
            currentSateCbx.SelectedValue = EnumsList.GetCurrentStateEnum()?.FirstOrDefault(p => p.Description == row.Cells[5].Value.ToString())?.Enum;
            resourcesTxt.Text = row.Cells[6].Value.ToString(); // Resources
            nameTxt.Text = row.Cells[7].Value.ToString(); // Name
            descriptionTxt.Text = row.Cells[8].Value.ToString(); // Description
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = productionDataGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a deleção, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = productionDataGridView.Rows[rowIndex];
            var productionId = Convert.ToInt32(row.Cells[0].Value); // ID

            var success = ProductionService.Delete(productionId);
            if (!success)
            {
                MessageBox.Show("Erro ao deletar o registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productionDataGridView.DataSource = ProductionService.GetAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            productionBindingSource.DataSource = new Production();
            productionIdTxt.Text = string.Empty;
        }

        /// <summary>
        /// Valida a obrigatoriedade dos campos do formulário, setando erro no errorProvider1 se não forem válidos
        /// <para>O errorProvider1 exibe erros nos campos da tela</para>
        /// </summary>
        /// <param name="production"></param>
        private void ValidateFields(Production production)
        {
            errorProvider1.Clear(); // Clear para sempre limpar os erros antes de checar novamente
            var message = "Campo obrigatório";

            if (production.StartDate == DateTime.MinValue)
            {
                errorProvider1.SetError(initialDateTxt, message);
            }

            if (production.EndDate == DateTime.MinValue)
            {
                errorProvider1.SetError(finalDateTxt, message);
            }

            if (string.IsNullOrWhiteSpace(production.Location))
            {
                errorProvider1.SetError(locationTxt, message);
            }

            if (string.IsNullOrWhiteSpace(production.ProductionMethod))
            {
                errorProvider1.SetError(methodTxt, message);
            }

            if (production.CurrentState == Enums.CurrentState.None)
            {
                errorProvider1.SetError(currentSateCbx, message);
            }

            if (string.IsNullOrWhiteSpace(production.ResourcesUsed))
            {
                errorProvider1.SetError(resourcesTxt, message);
            }

            if (string.IsNullOrWhiteSpace(production.Name))
            {
                errorProvider1.SetError(nameTxt, message);
            }

            if (string.IsNullOrWhiteSpace(production.Description))
            {
                errorProvider1.SetError(descriptionTxt, message);
            }
        }
    }
}
