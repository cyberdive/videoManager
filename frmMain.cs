using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_manager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merci de charger un fichier qui contient les chemins vers les videos");
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    //je dois lire le fichier, et ligne par ligne 
                    //- checker que c'est une video
                    //- mettre sa tailler
                    //- essayer de trouver le codec, format et résolution

                    //Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                   // using (StreamReader reader = new StreamReader(fileStream))
                    //{
                     //   fileContent = reader.ReadToEnd();
                    //}
                }
            }

            MessageBox.Show( filePath, MessageBoxButtons.OK.ToString());
        }

        private void btnShowdata_Click(object sender, EventArgs e)
        {
            frmData frmData1 = new frmData();
            frmData1.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmsettings1 = new frmSettings();
            frmsettings1.Show();
        }

        private void btnCpy_Click(object sender, EventArgs e)
        {
            //ici je dois lister les videos de la db qui ne sont pas copiés
            //je dois copier les videos et les renommer avec leurs id et leur extension
            // update du status à copié + log
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            //ici je dois lister toutes les videos
            // recherche si la video existe dans la db
            // si oui, je dois la renommer à son emplacement d'origine et déplacer l'original dans le dossier de backup
            // update du status à merged + log
        }
    }
}
