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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // service operations here
        #region Users
        [OperationContract]
        GetPersonResponse GetPerson(GetPersonRequest request);
        [OperationContract]
        AuthenticateUserResponse AuthenticateUser(AuthenticateUserRequest request);
        [OperationContract]
        RegisterUserResponse RegisterUser(RegisterUserRequest request);
        [OperationContract]
        GetApprovedUsersResponse GetApprovedUsers();
        [OperationContract]
        GetApprovedAdminsResponse GetApprovedAdmins();
        [OperationContract]
        GetNotApprovedUsersResponse GetNotApprovedUsers();
        [OperationContract]
        ApproveUserResponse ApproveUser(ApproveUserRequest request);
        [OperationContract]
        ApproveAdminResponse ApproveAdmin(ApproveAdminRequest request);
        [OperationContract]
        DeleteUserResponse DeleteUser(DeleteUserRequest request);
        
        #endregion

        #region News
        [OperationContract]
        GetNewsItemsResponse GetNewsItems();
        [OperationContract]
        GetPublishedNewsItemsResponse GetPublishedNewsItems();
        [OperationContract]
        GetNewsItemByIdResponse GetNewsItemById(GetNewsItemByIdRequest request);
        [OperationContract]
        InsertNewsItemResponse InsertNewsItem(InsertNewsItemRequest request);
        [OperationContract]
        PublishNewsItemResponse PublishNewsItem(PublishNewsItemRequest request);
        [OperationContract]
        DeleteNewsItemResponse DeleteNewsItem(DeleteNewsItemRequest request);
        [OperationContract]
        UpdateNewsItemResponse UpdateNewsItem(UpdateNewsItemRequest request);
        #endregion
       
        #region Files
        [OperationContract]
        GetFileRecordResponse GetFileRecord();
        [OperationContract]
        InsertFileRecordResponse InsertFileRecord(InsertFileRecordRequest request);
        [OperationContract]
        LogFileDownloadResponse LogFileDownload(LogFileDownloadRequest request);
        #endregion

        #region Tutorials
        [OperationContract]
        InsertTutorialItemResponse InsertTutorialItem(InsertTutorialItemRequest request);
        [OperationContract]
        GetTutorialItemsResponse GetTutorialItems();
        [OperationContract]
        GetPublishTutoItemsResponse GetPublishTutoItems();
        [OperationContract]
        PublishTutorialItemResponse PublishTutorialItem(PublishTutorialItemRequest request);
        [OperationContract]
        GetTutorialItemByIdResponse GetTutorialItemById(GetTutorialItemByIdRequest request);
        [OperationContract]
        DeleteTutorialItemResponse DeleteTutorialItem(DeleteTutorialItemRequest request);
        [OperationContract]
        UpdateTutorialItemResponse UpdateTutorialItem(UpdateTutorialItemRequest request);
        #endregion

        #region Comments

        [OperationContract]
        InsertCommentResponse InsertComment(InsertCommentRequest request);
        [OperationContract]
        GetPublishedCommentsResponse GetPublishedComments();
        [OperationContract]
        GetUnpublishedCommentsResponse GetUnpublishedComments();
        [OperationContract]
        PublishCommentResponse PublishComment(PublishCommentRequest request);
        [OperationContract]
        DeleteCommentResponse DeleteComment(DeleteCommentRequest request);
        
        #endregion

        #region Youtube
        [OperationContract]
        GetUrlYoutubeResponse GetUrlYoutube();
        [OperationContract]
        InsertUrlYoutubeResponse InsertUrlYoutube(InsertUrlYoutubeRequest request);
        #endregion

        #region Contact
        [OperationContract]
        GetContactsResponse GetContacts();
        [OperationContract]
        InsertContactResponse InsertContact(InsertContactRequest request);
        [OperationContract]
        DeleteContactResponse DeleteContact(DeleteContactRequest request);
        #endregion

        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
