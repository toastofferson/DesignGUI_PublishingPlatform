﻿using Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Services
{
    [ServiceContract]
    public interface INewsService
    {
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        List<News> GetNews();
        // One news
        [OperationContract]
        News GetNewsById(string id);

        // Temporary
        [OperationContract]
        List<Tutorial> GetTutorials();
        // One Tutorial , all pages
        [OperationContract]
        List<Tutorial> GetTutorialById(string id);

        [OperationContract]
        Tutorial GetTutorialByIdAndPage(string id, string page);
    }

    
}