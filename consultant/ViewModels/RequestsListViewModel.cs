using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using consultant.Models;
using Microsoft.AspNetCore.SignalR.Client;


namespace consultant.ViewModels
{
    public class RequestsListViewModel : BaseViewModel
    {
        public HubConnection hubConnection;
        public ObservableCollection<RequestModel> Requests { get; set; }
        public RequestsListViewModel()
        {
            Requests = new ObservableCollection<RequestModel>();
            
            Requests.Add(new RequestModel()
            {
                Title = "My new Request",
                Date = DateTime.Now.ToString("HH:mm"),
                RoomNumber = 3.ToString()
            });
            
            Requests.Add(new RequestModel()
            {
                Title = "My new Request",
                Date = DateTime.Now.ToString("HH:mm"),
                RoomNumber = 3.ToString()
            });

            OnButtonClick = new Command(() =>
            {
                Requests.Add(new RequestModel()
                {
                    Title = "My new Request",
                    Date = DateTime.Now.ToString("HH:mm"),
                    RoomNumber = 3.ToString()
                });
                
                OnPropertyChanged(nameof(Requests));
            });
        }

        public Command OnButtonClick { get; }
    }
}