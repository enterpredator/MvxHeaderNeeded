using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;

namespace MvxHeaderNeeded.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private string _userAvatar;
        public string UserAvatar
        {
            get { return _userAvatar; }
            set { _userAvatar = value; RaisePropertyChanged(() => UserAvatar); }
        }

        private int _summ;
        public int Summ
        {
            get
            {
                _summ = 0;
                foreach (var simpleItem in MyAccounts)
                {
                    _summ += simpleItem.Value;
                }
                return _summ;
            }
            set { _summ = value; RaisePropertyChanged(() => Summ); }
        }

        private List<SimpleItem> _myAccounts;
        public List<SimpleItem> MyAccounts
        {
            get { return _myAccounts; }
            set { _myAccounts = value; RaisePropertyChanged(() => MyAccounts); }
        }

        public FirstViewModel()
        {
            MyAccounts = MakeStubs();
            UserAvatar = "https://avatars0.githubusercontent.com/u/3115057?s=460";
        }

        private List<SimpleItem> MakeStubs()
        {
            var list = new List<SimpleItem>();
            for (var i = 1; i < 11; i++)
            {
                list.Add(new SimpleItem(string.Format("Some bank ¹ {0}", i), i * 1000));
            }
            return list;
        }
    }

    public class SimpleItem : MvxViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged(() => Name); }
        }

        private int _value;

        public SimpleItem(string accountName, int value)
        {
            _name = accountName;
            _value = value;
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; RaisePropertyChanged(() => Value); }
        }
    }
}
