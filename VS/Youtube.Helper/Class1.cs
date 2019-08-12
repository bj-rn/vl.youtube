using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using Google.Apis.Requests;
using Google.Apis.Upload;
using Google.Apis.YouTube.v3.Data;
using System.Reactive.Linq;
using Google.Apis.YouTube.v3;

namespace YouTube.Helper
{
    public static class YTUploadExtensions
    {


        public static ResumableUpload AddProgressEventHandler <T> (this ResumableUpload<T> upload, Action<IUploadProgress> callback)
        {
            upload.ProgressChanged += callback;

            return upload;

        }

        public static ResumableUpload RemoveProgressEventHandler <T> (this ResumableUpload<T> upload, Action<IUploadProgress> callback)
        {
            upload.ProgressChanged -= callback;

            return upload;
        }


        public static ResumableUpload AddResponseEventHandler <T> (this ResumableUpload<T, T> upload, Action<T> callback)
        {
            upload.ResponseReceived += callback;

            return upload;

        }

        public static ResumableUpload RemoveResponseEventHandler <T> (this ResumableUpload<T, T> upload, Action<T> callback)
        {
            upload.ResponseReceived -= callback;

            return upload;
        }

    }
}
