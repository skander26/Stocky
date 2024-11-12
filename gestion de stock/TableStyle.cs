using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace gestion_de_stock
{
    internal class TableStyle
    {
        public static void select_change(object sender, CellFormattingEventArgs e)
        {



            e.CellElement.ForeColor = Color.Black;
            if (e.CellElement.IsCurrent)
            {
                e.CellElement.DrawFill = true;
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
                e.CellElement.BackColor = Color.FromArgb(28, 193, 234);


            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty);
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty);
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty);


            }




        }
        public static void select_changee(object sender, RowFormattingEventArgs e)
        {
            e.RowElement.ForeColor = Color.Black;
            
            if (e.RowElement.IsCurrent)
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
                e.RowElement.BackColor = Color.FromArgb(28, 193, 234);



            }
            else
            {
                e.RowElement.ResetValue(LightVisualElement.DrawFillProperty);
                e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty);
                e.RowElement.ResetValue(LightVisualElement.BackColorProperty);

            }

        }
    }

}
