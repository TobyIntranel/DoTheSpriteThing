namespace DoTheSpriteThing
{
    public interface ISpriteImage : IImage
    {
        IHoverImage HoverImage { get; }

        string Key { get; }

        string PlaceholderImageKey { get; }

        bool Resize { get; }

        int ResizeToHeight { get; }

        int ResizeToWidth { get; }
    }
}