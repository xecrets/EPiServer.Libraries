﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonContoller.cs" company="Jeroen Stemerdink">
//   Copyright© 2013 Jeroen Stemerdink. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace EPiServer.Libraries.Mvc.Output.Channels.Controllers
{
    using System.Web.Mvc;

    using EPiServer.Core;
    using EPiServer.Framework.DataAnnotations;
    using EPiServer.Libraries.Output;
    using EPiServer.Libraries.Output.Helpers;
    using EPiServer.Web.Mvc;

    /// <summary>
    ///     The pdf controller.
    /// </summary>
    [TemplateDescriptor(Inherited = true, Tags = new[] { OutputConstants.JSON })]
    public class JsonController : PageController<PageData>
    {
        #region Public Methods and Operators

        /// <summary>
        /// The index.
        /// </summary>
        /// <param name="currentPage">
        /// The current page.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index(PageData currentPage)
        {
            OutputHelper.HandleJson(currentPage);

            return new EmptyResult();
        }

        #endregion
    }
}