using System;
using System.Collections.Generic;

namespace consultant.Models
{
    public class RequestsListModel
    {
        public List<RequestModel> Requests { get; private set; }

        public RequestsListModel()
        {
            Requests = new List<RequestModel>();
        }

        public void addItem(RequestModel request)
        {
            this.Requests.Add(request);
        }
        
    }
}