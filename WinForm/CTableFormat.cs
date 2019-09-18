using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinForm
{
    /// <summary>
    /// The class formats the display in a grid table
    /// </summary>
    class CTableFormat
    {

        public struct jCp
        {
            public int N;       //Id value
            public string S;    //column name
            public int W;       //column width
            public int R;       //Right aligned

            public string F;    //Content display format
            public Color Cl;    //Color of the text
            public Type T;      //Type of variable
            public string Tt;   //TipTool text

            public jCp(int xN, string xS, int xW, int xR, string xF, Color xCl, Type xT, string xTt = "")
            {
                this.N = xN;
                this.S = xS;
                this.W = xW;
                this.R = xR;
                this.F = xF;
                this.Cl = xCl;
                this.T = xT;
                this.Tt = xTt;
            }
        }

        public CTableFormat()
        {
        }

        public void FormatColumnGrid(ref DataGridView xDataGridView, int xnumberTable)
        {   
            if (xnumberTable == 1)
            {
                mInitColumnsGrid(ref xDataGridView, lPerson, true);
            }
        }


        public void mInitColumnsGrid(ref DataGridView xDataGridView, List<jCp> xList, bool xbHeader)
        {   //Defin Column in xDataTable
            int i = 0;
            int iList = 0;
            string ast = "";
            Color aColor = default(Color);

            xDataGridView.RowHeadersVisible = xbHeader;
            xDataGridView.RowHeadersWidth = 15;

            int aiGrid = xDataGridView.Columns.Count;

            for (i = 0; i < aiGrid; i++) //Flies over all Grid columns (initialized by DataSource)
            {
                ast = xDataGridView.Columns[i].Name;    //Column name
                iList = mGetIndexDefineAll(ast, xList); //finds index on Name in the table

                if (iList > -1) //when it found such a column definition as the Grid column
                { 
                    aColor = xList[iList].Cl;
                    xDataGridView.Columns[i].DefaultCellStyle.ForeColor = aColor;

                    //Format
                    if (xList[iList].F != "")
                        xDataGridView.Columns[i].DefaultCellStyle.Format = xList[iList].F;

                    //Width column
                    xDataGridView.Columns[i].Width = xList[iList].W;

                    if (xList[iList].R > 0) //AlignRight
                        xDataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        public int mGetIndexDefineAll(string xNameCol, List<jCp> xListDefine) //znajduje index na Nazwę w tabeli DefineAll
        {
            int jcol = xListDefine.Count;
            int j = -1;

            for (var i = 0; i < jcol; i++)
            {
                if (xListDefine[i].S == xNameCol)
                {
                    j = i;
                    break;  //wyskakuje z pętli
                }
            }
            return (j);
        }

        //List of the Sprinters database
        static List<jCp> lPerson = new List<jCp>
        {
            new jCp{ N= 1, S = "Id"     , W = 30, R= 1, F= "", Cl = Color.Black, T= typeof(int) },

            new jCp{ N= 2, S = "name"   , W = 60, R= 0, F= "", Cl = Color.DarkBlue, T= typeof(string)},
            new jCp{ N= 4, S = "surname", W = 75, R= 0, F= "", Cl = Color.DarkBlue, T= typeof(string)},

            new jCp{ N= 7, S = "age"    , W = 35 ,R= 1, F= "0.0", Cl = Color.Brown, T= typeof(float)},
            new jCp{ N= 4, S = "city"   , W = 65, R= 0, F= ""   , Cl = Color.Blue, T= typeof(string)},
            new jCp{ N= 7, S = "height" , W = 50 ,R= 1, F= "0.0", Cl = Color.Green, T= typeof(float)}
        };

    }
}
