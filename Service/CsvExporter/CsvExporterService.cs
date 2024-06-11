using FazendaUrbana.Forms.Utils;

namespace FazendaUrbana.Forms.Service.CsvExporter
{
    public class CsvExporterService
    {
        public void ExportCsv<T>(List<T> data, string baseFileName, string[] ignoreProperties)
        {
            if (data == null)
                return;

            // Criar o diretório para salvar o arquivo CSV
            string caminhoBase = @"C:\Relatorios";
            string nomePasta = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string caminhoPasta = Path.Combine(caminhoBase, nomePasta);
            Directory.CreateDirectory(caminhoPasta);

            // Criar o caminho completo do arquivo CSV
            string caminhoArquivo = Path.Combine(caminhoPasta, $"{baseFileName}.csv");

            // Obter propriedades do tipo genérico T
            var properties = typeof(T).GetProperties().Where(p => !ignoreProperties.Contains(p.Name));

            // Criar e escrever no arquivo CSV
            using (var writer = new StreamWriter(caminhoArquivo))
            {
                // Escrever o cabeçalho com os nomes das propriedades
                writer.WriteLine(string.Join(",", properties.Select(p =>
                                p.GetCustomAttributes(typeof(CsvColumnNameAttribute), false).FirstOrDefault() is CsvColumnNameAttribute attr ? attr.Name : p.Name)));

                // Escrever cada objeto de dados como uma linha no CSV
                foreach (var item in data)
                {
                    string linha = string.Join(",", properties.Select(p => (p.GetValue(item, null)?.ToString()?.Replace(",", ";") ?? "")));
                    writer.WriteLine(linha);
                }
            }
        }
    }
}
