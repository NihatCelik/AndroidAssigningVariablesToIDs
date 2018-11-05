using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AndroidAssigningVariablesToIDs
{
    public partial class Form1 : Form
    {
        List<KeyValuePair<string, string>> listComponents = new List<KeyValuePair<string, string>>();
        List<string> listRows = new List<string>();
        List<string> listVariables = new List<string>();
        public Form1()
        {
            InitializeComponent();
            txtXml.AllowDrop = true;
            txtXml.DragDrop += TxtXml_DragDrop;
        }

        private void TxtXml_DragDrop(object sender, DragEventArgs e)
        {
            object filename = e.Data.GetData("FileDrop");
            if (filename != null)
            {
                var list = filename as string[];

                if (list != null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    string path = list[0];
                    if (path.Substring(path.Length - 4) != ".xml") return;
                    txtXml.Clear();
                    txtXml.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void btnDefinitionVariables_Click(object sender, EventArgs e)
        {
            listRows.Clear();
            listVariables.Clear();
            listComponents.Clear();

            string xml = txtXml.Text.Trim();
            string[] components = Regex.Split(xml, "<");

            foreach (string item in components) listRows.Add(item);

            for (int i = listRows.Count - 1; i >= 0; i--)
            {
                string item = listRows[i];
                if (!item.Contains("android:id=\"@+id/")) listRows.RemoveAt(i);
            }

            string component = "", variableName = "";

            listRows.Sort();

            for (int i = 0; i < listRows.Count; i++)
            {
                string item = listRows[i];

                int startIndex = 0;
                int lastIndex = item.IndexOf("\n");

                component = item.Substring(startIndex, lastIndex);

                startIndex = item.IndexOf("@+id/");
                lastIndex = item.IndexOf("\"\n", startIndex);
                variableName = item.Substring(startIndex + 5, lastIndex - startIndex - 5);

                listRows[i] = component + " " + variableName;

                listComponents.Add(new KeyValuePair<string, string>(component, variableName));
            }

            string text = "";
            string previousDataType = "";
            for (int i = 0; i < listComponents.Count; i++)
            {
                string dataType = listComponents[i].Key;
                string variable = listComponents[i].Value;
                if (previousDataType != dataType) text += ";" + Environment.NewLine + dataType + " " + variable;
                else text += ", " + variable;
                previousDataType = dataType;
            }
            text = text.Substring(3) + ";";
            txtResult.Text = text;
        }

        private void btnAssigningVariablesToIDs_Click(object sender, EventArgs e)
        {
            string text = "";
            string previousDataType = "";
            for (int i = 0; i < listComponents.Count; i++)
            {
                string dataType = listComponents[i].Key;
                if (dataType != previousDataType) text += Environment.NewLine;
                string variable = listComponents[i].Value; 
                text += variable + " = (" + dataType + ") ";
                if (rbFragment.Checked) text += "view.";
                text += "findViewById(R.id." + variable + ");" + Environment.NewLine;
                previousDataType = dataType;
            }
            text = text.Substring(2);
            txtResult.Text = text;
        }
    }
}
