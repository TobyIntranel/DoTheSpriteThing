﻿namespace DoTheSpriteThing
{
    /// <summary>
    /// A byte array image.
    /// </summary>
    public class ByteArraySpriteImage : ISpriteImage, IByteArrayImage
    {
        /// <summary>
        /// Create the byte array image.
        /// </summary>
        /// <param name="key">The ID of the HTML element in which to display the image.</param>
        /// <param name="imageData">The image data.</param>
        /// <param name="placeholderImageKey">The key of the placeholder image to use when image data is null.</param>        
        public ByteArraySpriteImage(string key, byte[] imageData, string placeholderImageKey)
        {
            Key = key;
            ImageData = imageData;
            PlaceholderImageKey = placeholderImageKey;
            Resize = false;
        }

        /// <summary>
        /// Create the byte array image.
        /// </summary>
        /// <param name="key">The ID of the HTML element in which to display the image.</param>
        /// <param name="imageData">The image data.</param>
        /// <param name="placeholderImageKey">The key of the placeholder image to use when image data is null.</param>   
        /// <param name="hoverImage">The image to display when hovering over the image.</param>             
        public ByteArraySpriteImage(string key, byte[] imageData, string placeholderImageKey, IHoverImage hoverImage)
        {
            Key = key;
            ImageData = imageData;
            PlaceholderImageKey = placeholderImageKey;
            HoverImage = hoverImage;
            Resize = false;
        }

        /// <summary>
        /// Create the byte array image.
        /// </summary>
        /// <param name="key">The ID of the HTML element in which to display the image.</param>
        /// <param name="imageData">The image data.</param>        
        public ByteArraySpriteImage(string key, byte[] imageData)
        {
            Key = key;
            ImageData = imageData;
            Resize = false;
        }

        /// <summary>
        /// Create the byte array image.
        /// </summary>
        /// <param name="key">The ID of the HTML element in which to display the image.</param>
        /// <param name="imageData">The image data.</param>
        /// <param name="hoverImage">The image to display when hovering over the image.</param>             
        public ByteArraySpriteImage(string key, byte[] imageData, IHoverImage hoverImage)
        {
            Key = key;
            ImageData = imageData;
            HoverImage = hoverImage;
            Resize = false;
        }

        /// <summary>
        /// Create the byte array image.
        /// </summary>
        /// <param name="key">The ID of the HTML element in which to display the image.</param>
        /// <param name="imageData">The image data.</param>
        /// <param name="placeholderImageKey">The key of the placeholder image to use when image data is null.</param>
        /// <param name="resizeToHeight">The height in pixels to resize the image to.</param>
        /// <param name="resizeToWidth">The width in pixels to resize the image to.</param>
        public ByteArraySpriteImage(string key, byte[] imageData, string placeholderImageKey, int resizeToHeight, int resizeToWidth)
        {
            Key = key;
            ImageData = imageData;
            PlaceholderImageKey = placeholderImageKey;
            Resize = true;
            ResizeToHeight = resizeToHeight;
            ResizeToWidth = resizeToWidth;
        }

        /// <summary>
        /// Create the byte array image.
        /// </summary>
        /// <param name="key">The ID of the HTML element in which to display the image.</param>
        /// <param name="imageData">The image data.</param>
        /// <param name="placeholderImageKey">The key of the placeholder image to use when image data is null.</param>
        /// <param name="resizeToHeight">The height in pixels to resize the image to.</param>
        /// <param name="resizeToWidth">The width in pixels to resize the image to.</param>
        /// <param name="hoverImage">The image to display when hovering over the image.</param> 
        public ByteArraySpriteImage(string key, byte[] imageData, string placeholderImageKey, int resizeToHeight, int resizeToWidth, IHoverImage hoverImage)
        {
            Key = key;
            ImageData = imageData;
            PlaceholderImageKey = placeholderImageKey;
            Resize = true;
            ResizeToHeight = resizeToHeight;
            ResizeToWidth = resizeToWidth;
            HoverImage = hoverImage;
        }

        /// <summary>
        /// Create the byte array image.
        /// </summary>
        /// <param name="key">The ID of the HTML element in which to display the image.</param>
        /// <param name="imageData">The image data.</param>        
        /// <param name="resizeToHeight">The height in pixels to resize the image to.</param>
        /// <param name="resizeToWidth">The width in pixels to resize the image to.</param>
        public ByteArraySpriteImage(string key, byte[] imageData, int resizeToHeight, int resizeToWidth)
        {
            Key = key;
            ImageData = imageData;
            Resize = true;
            ResizeToHeight = resizeToHeight;
            ResizeToWidth = resizeToWidth;
        }

        /// <summary>
        /// Create the byte array image.
        /// </summary>
        /// <param name="key">The ID of the HTML element in which to display the image.</param>
        /// <param name="imageData">The image data.</param>        
        /// <param name="resizeToHeight">The height in pixels to resize the image to.</param>
        /// <param name="resizeToWidth">The width in pixels to resize the image to.</param>
        /// <param name="hoverImage">The image to display when hovering over the image.</param> 
        public ByteArraySpriteImage(string key, byte[] imageData, int resizeToHeight, int resizeToWidth, IHoverImage hoverImage)
        {
            Key = key;
            ImageData = imageData;
            Resize = true;
            ResizeToHeight = resizeToHeight;
            ResizeToWidth = resizeToWidth;
            HoverImage = hoverImage;
        }

        /// <summary>
        /// The image to display when hovering over the image.
        /// </summary>
        public IHoverImage HoverImage { get; }

        public byte[] ImageData { get; }

        /// <summary>
        /// The ID of the HTML element in which to display the image.
        /// </summary>
        public string Key { get; }

        public string PlaceholderImageKey { get; }

        public bool Resize { get; }

        /// <summary>
        /// The height in pixels to resize the image to.
        /// </summary>
        public int ResizeToHeight { get; }

        /// <summary>
        /// The width in pixels to resize the image to.
        /// </summary>
        public int ResizeToWidth { get; }
    }
}