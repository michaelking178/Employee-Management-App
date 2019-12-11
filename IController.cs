using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_App.Models;
using Employee_Management_App.Views;

namespace Employee_Management_App
{
    interface IController
    {
        void UpdateListView();
        void Add();
        void SetItemToEdit();
        void Edit();
        void Remove();
        void PopulateEditForm();
    }
}
