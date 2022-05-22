using ModernChat.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernChat.MVVM.ViewModel
{
     class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            {
                Username = "Sasha",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/ddkrJYj.png",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Саня",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.imgur.com/ddkrJYj.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }
            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Антон",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.imgur.com/ddkrJYj.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true
                });
            }

                Messages.Add(new MessageModel
                {
                    Username = "Санек",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.imgur.com/ddkrJYj.png",
                    Message = "Last",
                    Time = DateTime.Now,
                    IsNativeOrigin = true
                });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Sanya{i}",
/*                    ImageSource= "https://i.imgur.com/GtolBwW.png",*/
                    Messages = Messages
                });
            }
        }
    }
}
