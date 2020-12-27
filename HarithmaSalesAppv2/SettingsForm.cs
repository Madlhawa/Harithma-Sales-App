using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarithmaSalesAppv2
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        string connectionString, server, database = "";

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["HarithmaSalesEntities"].ConnectionString.ToString();

            char[] delimiterChars = { '=', ';' };
            string[] words = connectionString.Split(delimiterChars);

            server = words[Array.IndexOf(words, "\"data source") + 1];
            database = words[Array.IndexOf(words, "initial catalog") + 1];

            txtServer.Text = server;
            txtDatabase.Text = database;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatedConnectionString = connectionString.Replace(server, txtServer.Text);
            updatedConnectionString = updatedConnectionString.Replace(database, txtDatabase.Text);

            MessageBox.Show(updatedConnectionString);

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["HarithmaSalesEntities"].ConnectionString = updatedConnectionString;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
