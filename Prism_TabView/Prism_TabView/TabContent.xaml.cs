﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prism_TabView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabContent : ContentView
	{
		public TabContent ()
		{
			InitializeComponent ();
        }
    }
    public class ContactInfo
    {
        public string Name { get; set; }
        public long Number { get; set; }
    }
    public class ContactsViewModel
    {
        private ObservableCollection<ContactInfo> contactList;

        public ObservableCollection<ContactInfo> ContactList
        {
            get { return contactList; }
            set { contactList = value; }
        }
        public ContactsViewModel()
        {
            ContactList = new ObservableCollection<ContactInfo>();
            ContactList.Add(new ContactInfo { Name = "Aaron", Number = 7363750 });
            ContactList.Add(new ContactInfo { Name = "Adam", Number = 7323250 });
            ContactList.Add(new ContactInfo { Name = "Barry", Number = 7317750 });
            ContactList.Add(new ContactInfo { Name = "Blexo", Number = 7363750 });
            ContactList.Add(new ContactInfo { Name = "Cassey", Number = 7323250 });
            ContactList.Add(new ContactInfo { Name = "Danny", Number = 7239121 });
            ContactList.Add(new ContactInfo { Name = "Edwin", Number = 2329823 });
            ContactList.Add(new ContactInfo { Name = "Jacob", Number = 8013481 });
            ContactList.Add(new ContactInfo { Name = "Jessie", Number = 7872329 });
            ContactList.Add(new ContactInfo { Name = "Linda", Number = 7317750 });
        }
    }
}