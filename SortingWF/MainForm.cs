using System.Reflection;

namespace SortingWF
{
    public partial class MainForm : Form
    {

        int[] testArr = new int[] { 9, 1, 3, 5, 4, 2, 6, 7, 8, 10, 0 };
        CancellationTokenSource cts = new CancellationTokenSource();
        bool runningSort = false;

        public MainForm()
        {
            InitializeComponent();

            var arrOfSorts = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(domainAssembly => domainAssembly.GetTypes())
                .Where(type => type.IsSubclassOf(typeof(Sorting.Sort)))
                .ToArray();

            foreach(var sort in arrOfSorts)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(sort.FullName, null, (sender, e) => startSort(sender, e));
                sortsToolStripMenuItem.DropDownItems.Add(tsmi);
            }
            Console.WriteLine("asdf");

            Sorting.BozoSort bs = new Sorting.BozoSort(this.displaySort);

        }

        public void startSort(object? sender, System.EventArgs e)
        {
            if (runningSort)
            {
                cts.Cancel();
                runningSort = false;
                cts = new CancellationTokenSource();
            } else
            {
                runningSort = true;
            }
            
            var s = (ToolStripMenuItem)sender;
            var sort = s.Text;
            Assembly sorting = Assembly.LoadFrom("Sorting.dll");
            Type? t = sorting.GetType(sort);
            
            var theSort = (Sorting.Sort)Activator.CreateInstance(t, this.displaySort);
            Random.Shared.Shuffle(this.testArr);
            theSort.sort(this.testArr, cts.Token);

        }

        public void displaySort(int[] arr)
        {
            displayPanel.Invalidate();
        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);
            using (SolidBrush sb = new SolidBrush(Color.Black))
            {
                Pen p = new Pen(Color.Tomato);

                var width = displayPanel.Width / testArr.Length;

                for (int i = 0; i < testArr.Length; i++)
                {
                    var x = width * i;

                    var height = (testArr[i] + 1) * (displayPanel.Height / testArr.Length);
                    var y = displayPanel.Height - height;
                    g.FillRectangle(sb, x, y, width, height);
                    g.DrawRectangle(p, x, y, width, height);

                }
            }

        }
    }
}
