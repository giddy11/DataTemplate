using ChatApp2.Models;
using ChatApp2.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChatApp2.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        void AddUser()
        {
            AllUsers.Add(new Person
            {
                FullName = fullName,
                Gender = gender,
                Address = address,
                Username = username
            });

            Gender = Gender.Male;
            FullName = string.Empty;
            Address = string.Empty;
            Username = string.Empty;
        }


        void ShowUser()
        {
            MessageBox.Show(selectedUser.Username);
        }

        private string username;

        public string Username { get => username; set => SetProperty(ref username, value); }

        private string address;

        public string Address { get => address; set => SetProperty(ref address, value); }

        private Gender gender;

        public Gender Gender { get => gender; set => SetProperty(ref gender, value); }

        private string fullName;

        public string FullName { get => fullName; set => SetProperty(ref fullName, value); }

        private ObservableCollection<Person> allUsers = new();

        public ObservableCollection<Person> AllUsers { get => allUsers; set => SetProperty(ref allUsers, value); }
        public Person SelectedUser { get => selectedUser; set => SetProperty(ref selectedUser, value); }

        private ICommand addUserCommand;
        public ICommand AddUserCommand => addUserCommand ??= new ActionCommand(AddUser, true);

        private ICommand showUserCommand;
        public ICommand ShowUserCommand => showUserCommand ??= new ActionCommand(ShowUser, true);

        private Person selectedUser;

        

        public List<Gender> Genders => new List<Gender> { Gender.Male, Gender.Female };


        #region Hierarcharchy

        

        public List<Node> nodes = new List<Node>
        {
            new Node("Solution 'CCSA_WPF' (1 of 1 project)")
            {
                    Children = new List<Node>
                    {
                        new Node("CCSA_WPF")
                        {
                            Children = new List<Node>
                            {
                                 new Node("Converters"),
                                 new Node("Model"),
                                 new Node("Service")
                            }
                        }
                       
                    }
            }
        };


        public List<Node> Nodes { get => nodes; set => nodes = value; }

        #endregion
    }
}
