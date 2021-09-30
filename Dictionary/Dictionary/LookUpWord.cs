using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;




namespace Dictionary
{
    class LookUpWord
    {
        //path the JSON file
        JObject data = JObject.Parse(File.ReadAllText(@"C:\Users\seanv\source\repos\DictionaryProgram\data.json"));
        public object ReturnDef(string word)
        {
            object term = new object(); 
            word = word.ToLower();
            if (data.ContainsKey(word))
            {
                var myWord = data[word];
                // loop through the value deleting the [] and extra space to make it look nice
                foreach (var value in myWord)
                {
                    //Console.WriteLine(item.Key);
                    term = value;
                }
            }
            else
            {
                term = "Could not find word.";
                return term;
            }
            return term;
        }
    }
}