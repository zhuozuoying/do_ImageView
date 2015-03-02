using doControlLib;
using doControlLib.Environment;
using doControlLib.tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doUIViewDesign
{
    class do_ImageView : doComponentUIView
    {
        public override void DrawControl(int _x, int _y, int _width, int _height, Graphics g)
        {
            base.DrawControl(_x, _y, _width, _height, g);

            string _source = this.CurrentModel.GetPropertyValue("source");
            string _scaletype = this.CurrentModel.GetPropertyValue("scaletype");
            string _defaultImage = this.CurrentModel.GetPropertyValue("defaultImage");
            if (_source != null && _source.Length > 0)
            {
                RectangleF _rect = new RectangleF(_x, _y, this.CurrentModel.Width, this.CurrentModel.Height);
                Image _image = doGlobalEnv.Instance.GetDesignImage(this.CurrentModel.UIPageEnv.pageFileFullName, _source);
                if (_image != null)
                {
                    g.DrawImage(_image, _rect);
                }
            }
        }
    }
}
