
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Practice
    {
        public class WordHelper
        {

            private FileInfo _fileInfo;

            public WordHelper(string fileName)
            {
                if (File.Exists(fileName))
                {
                    _fileInfo = new FileInfo(fileName);
                }
                else
                {
                    throw new ArgumentException("File not found");
                }
            }

            internal bool Proccess(Dictionary<string, string> items)
            {
                Word.Application app = null;
                try
                {
                    app = new Word.Application();
                    Object file = _fileInfo.FullName;
                    Object missing = Type.Missing;

                    app.Documents.Open(file);

                    foreach (var item in items)
                    {
                        Word.Find find = app.Selection.Find;
                        find.Text = item.Key;
                        find.Replacement.Text = item.Value;

                        Object wrap = Word.WdFindWrap.wdFindContinue;
                        Object replace = Word.WdReplace.wdReplaceAll;

                        find.Execute(FindText: Type.Missing,
                            MatchCase: false,
                            MatchWholeWord: false,
                            MatchWildcards: false,
                            MatchSoundsLike: missing,
                            MatchAllWordForms: false,
                            Forward: true,
                            Wrap: wrap,
                            Format: false,
                            ReplaceWith: missing,
                            Replace: replace);
                    }

                    /// Object newFileName = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString("yyyyMMdd") + _fileInfo.Name);
                   
                //Object newFileName = Path.Combine("C:\\Users\\max\\source\\repos\\app\\app\\bin\\Debug\\doc1.doc");
                Object newFileName = Path.Combine("C:\\Users\\user\\Desktop\\практика\\Practice\\WordsChanger");

                app.ActiveDocument.SaveAs2(newFileName);
                    app.ActiveDocument.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (app != null)
                    {
                        app.Quit();
                    }

                }
                return false;
            }
        }

    }


