﻿namespace AngleSharp.DOM.Html
{
    using System;

    /// <summary>
    /// Represents the HTML video element.
    /// </summary>
    sealed class HTMLVideoElement : HTMLMediaElement, IHtmlVideoElement
    {
        #region Fields

        Int32 _videoWidth;
        Int32 _videoHeight;

        #endregion

        #region ctor

        /// <summary>
        /// Creates a new HTML video element.
        /// </summary>
        internal HTMLVideoElement()
        {
            _name = Tags.Video;

            //TODO
            _videoHeight = 0;
            _videoWidth = 0;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the displayed width of the video element.
        /// </summary>
        public Int32 Width
        {
            get { return GetAttribute(AttributeNames.Width).ToInteger(_videoWidth); }
            set { SetAttribute(AttributeNames.Width, value.ToString()); }
        }

        /// <summary>
        /// Gets or sets the displayed height of the video element.
        /// </summary>
        public Int32 Height
        {
            get { return GetAttribute(AttributeNames.Height).ToInteger(_videoHeight); }
            set { SetAttribute(AttributeNames.Height, value.ToString()); }
        }

        /// <summary>
        /// Gets the width of the video.
        /// </summary>
        public Int32 VideoWidth
        {
            get { return _videoWidth; }
        }

        /// <summary>
        /// Gets the height of the video.
        /// </summary>
        public Int32 VideoHeight
        {
            get { return _videoHeight; }
        }

        /// <summary>
        /// Gets or sets the URL to a preview image.
        /// </summary>
        public String Poster
        {
            get { return GetAttribute(AttributeNames.Poster); }
            set { SetAttribute(AttributeNames.Poster, value); }
        }

        #endregion

        #region Internal properties

        /// <summary>
        /// Gets if the node is in the special category.
        /// </summary>
        protected internal override Boolean IsSpecial
        {
            get { return false; }
        }

        #endregion
    }
}
