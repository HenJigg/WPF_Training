using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFUI
{
    public class MainViewModel : ViewModelBase
    {
        private string title;

        /// <summary>
        /// 系统标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; RaisePropertyChanged(); }
        }

        public RelayCommand<string> ExecuteCommand { get; }

        public ObservableCollection<HeaderModel> HeaderModels { get; set; }

        public ObservableCollection<ButtonModel> ButtonModels { get; set; }

        public ObservableCollection<MenuModel> MenuModels { get; set; }

        public ObservableCollection<RecondModel> RecondModels { get; set; }

        public ObservableCollection<UserModel> UserModels { get; set; }

        public MainViewModel()
        {
            Title = "WPF实战训练营";
            ExecuteCommand = new RelayCommand<string>(Execute);
            InitServices();
        }

        void InitServices()
        {
            HeaderModels = new ObservableCollection<HeaderModel>();
            HeaderModels.Add(new HeaderModel() { Title = "现金积分", Background = "#FF2DA0F9", Count = "255,539", InCome = "+0.8%" });
            HeaderModels.Add(new HeaderModel() { Title = "商城积分", Background = "#FF68CA29", Count = "656,683", InCome = "+0.8%" });
            HeaderModels.Add(new HeaderModel() { Title = "理财积分", Background = "#FFFDA005", Count = "37,215", InCome = "+0.8%" });
            HeaderModels.Add(new HeaderModel() { Title = "激活码", Background = "#FF3EC6C4", Count = "49,201", InCome = "+0.8%" });
            HeaderModels.Add(new HeaderModel() { Title = "活跃用户", Background = "#FFE0706F", Count = "458,319", InCome = "+0.8%" });

            ButtonModels = new ObservableCollection<ButtonModel>();
            ButtonModels.Add(new ButtonModel() { Icon = "\xe720", Content = "用户" });
            ButtonModels.Add(new ButtonModel() { Icon = "\xe613", Content = "财务" });
            ButtonModels.Add(new ButtonModel() { Icon = "\xe62b", Content = "积分" });
            ButtonModels.Add(new ButtonModel() { Icon = "\xe636", Content = "市场" });
            ButtonModels.Add(new ButtonModel() { Icon = "\xe69a", Content = "客服" });

            MenuModels = new ObservableCollection<MenuModel>();
            MenuModels.Add(new MenuModel() { Foreground = "#FF2DA0F9", Icon = "\xe67a", Title = "我要投资" });
            MenuModels.Add(new MenuModel() { Foreground = "#FFFDA005", Icon = "\xe62b", Title = "积分商城" });
            MenuModels.Add(new MenuModel() { Foreground = "#FF3EC6C4", Icon = "\xe61d", Title = "兑换任务" });
            MenuModels.Add(new MenuModel() { Foreground = "#FF68CA29", Icon = "\xe6a8", Title = "线下充值" });

            RecondModels = new ObservableCollection<RecondModel>();
            RecondModels.Add(new RecondModel() { Count = -100, Time = "07-10" });
            RecondModels.Add(new RecondModel() { Count = -200, Time = "07-11" });
            RecondModels.Add(new RecondModel() { Count = -300, Time = "07-12" });
            RecondModels.Add(new RecondModel() { Count = -400, Time = "07-13" });

            UserModels = new ObservableCollection<UserModel>();
            UserModels.Add(new UserModel() { ImageUrl = "images/logo.png", Time = "07-13", Title = "看那飞奔的牛" });
            UserModels.Add(new UserModel() { ImageUrl = "images/logo.png", Time = "07-13", Title = "看那飞奔的牛" });
            UserModels.Add(new UserModel() { ImageUrl = "images/logo.png", Time = "07-13", Title = "看那飞奔的牛" });
        }

        private void Execute(string obj)
        {
            switch (obj)
            {
                case "用户": SendMessage(obj); break;
                case "财务": SendMessage(obj); break;
                case "积分": SendMessage(obj); break;
                case "市场": SendMessage(obj); break;
                case "客服": SendMessage(obj); break;
                case "退出": SendMessage(obj); break;
                case "修改资料": SendMessage(obj); break;
                case "推广链接": SendMessage(obj); break;
            }
        }

        void SendMessage(string Content)
        {
            Messenger.Default.Send(Content, "ShowInfomation");
        }
    }
}
