using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComDotNetSample
{
    [Guid("654DB6C5-F8EB-4F11-9532-CDA8B6CBBAF7")]
    [ComVisible(true)]
    public interface ICalculator
    {
        int Sum(int a, int b);
    }

    [Guid("65F7D09F-CFB4-4325-9B84-44BC6400B032")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class Calculator : ICalculator
    {
        public int Sum(int a, int b)
        {
            Form1 f = new Form1();
            f.Show();
            return a + b;
        }
    }
}