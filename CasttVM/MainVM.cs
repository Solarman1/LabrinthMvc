using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CasttVM
{
    public class MainVM : BL.BaseModel
    {
        private BL.FinderModel findered;

        public BL.FinderModel Findered
        {
            get { return findered; }
            set
            {
                findered = value;
                OnPropertyChanged("Findered");
            }
        }
    }
}
