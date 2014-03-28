using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicPlayer.Classes
{
    public class NoDoubleClickAutoCheckListview : ListView
    {
        private bool checkFromDoubleClick = false;
        private bool singleClick = false;

        protected override void OnItemCheck(ItemCheckEventArgs ice)
        {
            if (this.checkFromDoubleClick)
            {
                ice.NewValue = ice.CurrentValue;
                this.checkFromDoubleClick = false;
            }
            else if(singleClick == true)
            {
                ice.NewValue = ice.CurrentValue;
                singleClick = false;
            }
            else
                base.OnItemCheck(ice);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            // Is this a double-click?
            if ((e.Button == MouseButtons.Left) && (e.Clicks > 1))
            {
                this.checkFromDoubleClick = true;
            }
            else if((e.Button == MouseButtons.Left) && (e.Clicks == 1))
            {
                singleClick = true;
            }
            base.OnMouseDown(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            this.checkFromDoubleClick = false;
            base.OnKeyDown(e);
        }
    }
}
