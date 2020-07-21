using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Ehecatl
{
    public partial class Main : Form
    {
        Resources Dictionary = new Resources("Eng");
        public Main()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Initializes a OpenFileDialog instance 
            using (OpenFileDialog openfileDialog = new OpenFileDialog())
            {
                openfileDialog.RestoreDirectory = true;
                openfileDialog.Filter = "Excel files(*.xlsx;*.xls)|*.xlsx;*.xls";

                if (openfileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtExcelLocation.Text = openfileDialog.FileName;
                }
            }
        }

        private void btnInsertStock_Click(object sender, EventArgs e)
        {
            txtResponseMessage.Clear();
            Reader rd = new Reader();
            Consumer cm = new Consumer();
            string excelfileName = txtExcelLocation.Text;

            if (string.IsNullOrEmpty(excelfileName) || !File.Exists(excelfileName))
            {
                MessageBox.Show(Dictionary.INVALID_FILE());
                return;
            }

            try
            {
                //Read the Excel file
                DataTable dt = rd.ReadExcelFile(excelfileName);

                //Check there're no format errors
                //TO DO: check there're no format errors

                //Insert the stock
                cm.FulfillStockList(dt);

                //Inform results
                if (cm.InsertIsSuccessful)
                {
                    txtResponseMessage.Text = "The stock was inserted correctly!";
                }
                else
                {
                    MessageBox.Show("Some stock wasn't inserted correctly","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtResponseMessage.Text = cm.ResponseMessage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs. The error message is: " + ex.Message);
            }
        }
    }
}
