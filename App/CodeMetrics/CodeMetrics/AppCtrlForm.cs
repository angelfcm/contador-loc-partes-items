/*!
 * Métrica de código
 *
 * Angel Fernando Carriola Monroy
 *
 * Date: 09/09/2016
 *
 * Summary: 
 * Muestra una interfaz de usuario para subir un archivo .cs localmente 
 * y permite calcular el número de partes, items y loc encontrados en el código.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CodeMetrics
{
    public partial class AppCtrlForm : Form
    {
        string fileSource;
        CodeMetrics codeMetrics;
        Color calculateButtonStartColor;
        Color openFileButtonStartBorderColor;

        public AppCtrlForm()
        {
            InitializeComponent();
            calculateButtonStartColor = calculateButton.BackColor;
            openFileButtonStartBorderColor = openFileButton.FlatAppearance.BorderColor;
            ClearFile();

            partPanel.Visible = false;
        }

        void CalculateMetrics()
        {
            if (!System.IO.File.Exists(fileSource))
                return;

            ClearResult();
            codeMetrics = new CodeMetrics(fileSource);
            codeMetrics.CalculateMetrics();

            locTextBox.Text = codeMetrics.totalLoc.ToString();

            partsContent.SuspendLayout();
            foreach (CodePart part in codeMetrics.parts)
            {
                partsContent.Controls.Add(part);
            }
            partsContent.ResumeLayout(false);
            partsContent.PerformLayout();
        }

        void OpenFile()
        {
            openFileDialog.Filter = "Archivos .cs|*.cs";
            openFileDialog.Title = "Seleccionar arhivo CS";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileSource = openFileDialog.FileName;
                openedFileNameLabel.Text = openFileDialog.FileName;
                openFileButton.Image = Properties.Resources.document_file_2_outline_stroke;
                calculateButton.BackColor = calculateButtonStartColor;
                calculateButton.Cursor = Cursors.Hand;
                closeFileButton.Visible = true;
                calculateButton.Enabled = true;
            }
            else ClearFile();

            openFileDialog.Dispose();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateMetrics();
        }

        private void closeFileButton_Click(object sender, EventArgs e)
        {
            ClearFile();
        }

        void ClearFile()
        {
            fileSource = "";
            openedFileNameLabel.Text = "";
            openFileButton.Image = Properties.Resources.file_upload_48px;
            closeFileButton.Visible = false;
            calculateButton.Enabled = false;
            calculateButton.BackColor = Color.LightGray;
            calculateButton.Cursor = Cursors.Default;

            ClearResult();
        }

        private void openFileButton_MouseEnter(object sender, EventArgs e)
        {
            openFileButton.FlatAppearance.BorderColor = Color.DarkCyan;
        }

        private void openFileButton_MouseLeave(object sender, EventArgs e)
        {
            openFileButton.FlatAppearance.BorderColor = openFileButtonStartBorderColor;

        }

        void ClearResult()
        {
            locTextBox.Text = "";
            if (codeMetrics != null)
            {
                partsContent.SuspendLayout();
                foreach (CodePart part in codeMetrics.parts)
                {
                    part.Destroy();
                    partsContent.Controls.Remove(part);
                }
                partsContent.ResumeLayout(false);
                partsContent.PerformLayout();
                metricsContent = null;
            }
        }
    }
}
