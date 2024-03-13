using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFiche2
{
    public partial class Fm_principal : Form
    {
        public Fm_principal()
        {
            InitializeComponent();
        }

        private void mi_quitter_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous quitter l'application ?", "a", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (a == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

       

        private void mi_ouvrir_Click(object sender, EventArgs e)
        {
            if (od_ouvrir.ShowDialog() == DialogResult.OK)
            {
                rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        

        
        private void mi_enregistrerSous_Click_1(object sender, EventArgs e)
        {
            if (od_enregistrer.ShowDialog() == DialogResult.OK)
            {
                rt_texte.SaveFile(od_enregistrer.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void od_ouvrir_FileOk(object sender, CancelEventArgs e)
        {
            rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
        }

        private void od_enregistrer_FileOk(object sender, CancelEventArgs e)
        {
            rt_texte.SaveFile(od_enregistrer.FileName, RichTextBoxStreamType.PlainText);
        }
    }
}
