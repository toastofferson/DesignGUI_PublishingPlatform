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
    
    public class NewsService : INewsService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        /// <summary>
        /// Test service
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public News GetNewsById(string id)
        {
            return new News()
            {
                Id = 1,
                title = "I am the first news",
                text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                published = true,
                date_published = DateTime.Today,
                date_modified = DateTime.Today,
                userId = 1
            };
        }

        /// <summary>
        /// Test service
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public List<News> GetNews()
        {
            return new List<News>()
            {
                new News(){
                    Id = 1,
                    title = "I am the first news",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = true,
                    date_published = DateTime.Today,
                    date_modified = DateTime.Today,
                    userId = 1
                },
                new News(){
                    Id = 2,
                    title = "I am the second news",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = false,
                    userId = 1
                },
                new News(){
                    Id = 3,
                    title = "I am the third news",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = true,
                    date_published = DateTime.Today,
                    date_modified = DateTime.Today,
                    userId = 1
                },
                new News(){
                    Id = 4,
                    title = "I am the fourth news",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = true,
                    date_published = DateTime.Today,
                    date_modified = DateTime.Today,
                    userId = 1
                },
            };
        }

        /// <summary>
        /// Test service
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Tutorial> GetTutorialById(string id)
        {
            return new List<Tutorial>()
            {
                new Tutorial()
                {
                    Id = 1,
                    page = 1,
                    title = "I am the first news",
                    video = "https://www.youtube.com/embed/2MayabeF5ew",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = true,
                    date_published = DateTime.Today,
                    date_modified = DateTime.Today,
                    userId = 1
                },
                new Tutorial()
                {
                    Id = 1,
                    page = 2,
                    title = "I am the first news",
                    video = "https://www.youtube.com/embed/7qXdMcow7gM",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = true,
                    date_published = DateTime.Today,
                    date_modified = DateTime.Today,
                    userId = 1
                },
                new Tutorial()
                {
                    Id = 1,
                    page = 3,
                    title = "I am the first news",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = true,
                    date_published = DateTime.Today,
                    date_modified = DateTime.Today,
                    userId = 1
                }
            };
        }

        /// <summary>
        /// Test service
        /// </summary>
        /// <param name="id"></param>
        /// /// <param name="page"></param>
        /// <returns></returns>
        public Tutorial GetTutorialByIdAndPage(string id, string page)
        {
            return new Tutorial()
                {
                    Id = 1,
                    page = 1,
                    title = "I am the first news",
                    video = "https://www.youtube.com/embed/2MayabeF5ew",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = true,
                    date_published = DateTime.Today,
                    date_modified = DateTime.Today,
                    userId = 1
                };
        }

        /// <summary>
        /// Test service
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public List<Tutorial> GetTutorials()
        {
            return new List<Tutorial>()
            {
                new Tutorial(){
                    Id = 1,
                    title = "I am the first news",
                    video = "https://www.youtube.com/embed/2MayabeF5ew",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = true,
                    date_published = DateTime.Today,
                    date_modified = DateTime.Today,
                    userId = 1
                },
                new Tutorial(){
                    Id = 2,
                    title = "I am the second news",
                    video = "https://www.youtube.com/embed/7qXdMcow7gM",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = false,
                    userId = 1
                },
                new Tutorial(){
                    Id = 3,
                    title = "I am the third news",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = true,
                    date_published = DateTime.Today,
                    date_modified = DateTime.Today,
                    userId = 1
                },
                new Tutorial(){
                    Id = 4,
                    title = "I am the fourth news",
                    text = "<h1><b><u><span style=\"color:rgb(56, 118, 29);font-size: 40px;\">WYSIWYG</span></u></b></h1><div style=\"font-size:16px;\">In computing, a <b><span style=\"font-size:16px;\">WYSIWYG</span></b> editor is a system in which content (text and graphics) displayed onscreen during editing appears in a form closely corresponding to its appearance when printed or displayed as a finished product, which might be a printed document, web page, or slide presentation. <b><span style=\"font-size:16px;\">WYSIWYG</span></b> is an acronym for \"<i><b><span style=\"font-size:16px;\">what you see is what you get</span></b></i>\".</div><img src=\"http://jqueryte.com//img/sazova-park.jpg\" style=\"float:left; margin:0 10px 10px 0\" alt=\"Sazova Park, Eskisehir\"><span style=\"font-size:16px;\"><div style=\"font-size:16px; color: rgb(51, 51, 51);\">WYSIWYG implies a user interface that allows the user to view something very similar to the end result while the document is being created. In general <b><span style=\"font-size:16px;\">WYSIWYG</span></b> implies the ability to directly manipulate the layout of a document without having to type or remember names of layout commands The actual meaning depends on the user&#39;s perspective, e.g.</div><div style=\"font-size:16px;\">Modern software does a good job of optimizing the screen display for a particular type of output. For example, a word processor is optimized for output to a typical printer. The software often emulates the resolution of the printer in order to get as close as possible to <b><span style=\"font-size:16px;\">WYSIWYG</span></b>. However, that is not the main attraction of <b><span style=\"font-size:18px;\">WYSIWYG</span></b>, which is the ability of the user to be able to visualize what he or she is producing.</div><div style=\"font-size:16px;\"><p></div><div style=\"font-size:16px;\"></p></div><div style=\"font-size:16px;\"><span style=\"font-size:14px;color: rgb(102, 102, 102);\"><a href=\"http://en.wikipedia.org/wiki/WYSIWYG\">Source: wikipedia.org</a></span></div></span>",
                    published = true,
                    date_published = DateTime.Today,
                    date_modified = DateTime.Today,
                    userId = 1
                },
            };
        }
    }
}
