﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BizzebeeSharp.Entities;
using BizzebeeSharp.Extensions;
using BizzebeeSharp.Filters;
using BizzebeeSharp.Infrastructure;

namespace BizzebeeSharp.Services.MediaFile
{
    /// <summary>
    /// A service for manipulating Bizzebee media files.
    /// </summary>
    public class MediaFileService : BizzebeeService
    {
        /// <summary>
        /// Creates a new instance of <see cref="MediaFileService" />.
        /// </summary>
        /// <param name="myBizzebeeUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public MediaFileService(string myBizzebeeUrl, string shopAccessToken) : base(myBizzebeeUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of media files.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<MediaFileModelCollection> ListAsync(int page = 1)
        {
            var req = PrepareRequest("media-files");
            req.QueryParams.Add("page", page);
            return await ExecuteRequestAsync<MediaFileModelCollection>(req, HttpMethod.Get, rootElement: "");
        }

        /// <summary>
        /// Retrieves the <see cref="MediaFileModel"/> with the given id.
        /// </summary>
        /// <param name="mediaFileId">The id of the media file to retrieve.</param>
        /// <returns>The <see cref="MediaFileModel"/>.</returns>
        public virtual async Task<MediaFileModel> GetAsync(int mediaFileId)
        {
            var req = PrepareRequest($"media-files/{mediaFileId}");
            return await ExecuteRequestAsync<MediaFileModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Deletes a media file with the given Id.
        /// </summary>
        /// <param name="mediaFileId">The media file object's Id.</param>
        public virtual async Task DeleteAsync(int mediaFileId)
        {
            var req = PrepareRequest($"media-files/{mediaFileId}");
            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
