using System;
using System.Collections.Generic;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace ZIZHENG
{
    class ZTfont
    {

        private void OffsetRichText(RichTextBox box, int iStart, int iLength, int iOffset)
        {

            box.SelectionStart = iStart;
            box.SelectionLength = iLength;
            Font richFont1 = new Font("宋体", box.Font.Size - System.Math.Abs(iOffset));
            box.SelectionFont = richFont1;
            box.SelectionCharOffset = iOffset;
            box.SelectionStart = 0;
            box.SelectionLength = 0;

        }
    }
}
