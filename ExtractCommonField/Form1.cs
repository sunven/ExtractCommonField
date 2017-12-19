using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ExtractCommonField
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var classNameList = new List<string> { "CqBankXdbAssessmentResult1", "CqBankXdbAssessmentResult2", "CqBankXdbAssessmentResult3", "CqBankXdbAssessmentResult4" };
            //var assembly = Assembly.LoadFrom(@"C:\Work\DotNetTeamGit\Caad.Viss\Source\Common\Caad.Api\bin\Debug\Caad.Api.dll");
            //var types = assembly.GetTypes().Where(c => c.IsClass && classNameList.Contains(c.Name)).ToList();
            //var minCount = int.MaxValue;
            //Type minType = null;
            //foreach (var type in types)
            //{
            //    var count = type.GetProperties().Length;
            //    if (count >= minCount)
            //    {
            //        continue;
            //    }
            //    minCount = count;
            //    minType = type;
            //}
            //if (minType == null)
            //{
            //    return;
            //}
            //var propertyNameList = new List<string>();
            //foreach (var propertyInfo in minType.GetProperties())
            //{
            //    if (types.Count(c => c.GetProperties().Any(s => s.Name == propertyInfo.Name && s.PropertyType == propertyInfo.PropertyType)) != types.Count)
            //    {
            //        continue; ;
            //    }
            //    propertyNameList.Add(propertyInfo.Name);
            //}
            //MessageBox.Show(string.Join(",", propertyNameList));
            ////types.FirstOrDefault(c=>c.GetTypeInfo().GetProperties().m)
            ////var typeMin = types.Max(c => c.GetTypeInfo().GetProperties().Length);

        }

        private string[] GetClassNameList()
        {
            return txtClassName.Text.Split(',');
        }

        private string Search(string[] classNameList, List<Assembly> assemblyList)
        {
            //var classNameList = new List<string> { "CqBankXdbAssessmentResult1", "CqBankXdbAssessmentResult2", "CqBankXdbAssessmentResult3", "CqBankXdbAssessmentResult4" };
            var assembly = Assembly.LoadFrom(@"C:\Work\DotNetTeamGit\Caad.Viss\Source\Common\Caad.Api\bin\Debug\Caad.Api.dll");
            var types = new List<Type>();
            foreach (var assembly1 in assemblyList)
            {
                types.AddRange(assembly1.GetTypes().Where(s => s.IsClass && classNameList.Contains(s.Name)).ToList());
            }
            var minCount = int.MaxValue;
            Type minType = null;
            foreach (var type in types)
            {
                var count = type.GetProperties().Length;
                if (count >= minCount)
                {
                    continue;
                }
                minCount = count;
                minType = type;
            }
            if (minType == null)
            {
                return string.Empty;
            }
            var propertyNameList = new List<string>();
            foreach (var propertyInfo in minType.GetProperties())
            {
                if (types.Count(c => c.GetProperties().Any(s => s.Name == propertyInfo.Name && s.PropertyType == propertyInfo.PropertyType)) != types.Count)
                {
                    continue;
                }
                propertyNameList.Add(propertyInfo.Name);
            }
            return string.Join(",", propertyNameList);
        }

        private void btnSelFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = @"dll|*.dll;",
                Multiselect = true
            };
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var assemblyList = ofd.FileNames.Select(Assembly.LoadFrom).ToList();
            Search(GetClassNameList(), assemblyList);
        }

        private void btnSelDirectory_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var assemblyList = Directory.GetFiles(fbd.SelectedPath, "*.dll", SearchOption.AllDirectories)
                .Select(Assembly.LoadFrom).ToList();
            Search(GetClassNameList(), assemblyList);
        }
    }
}
