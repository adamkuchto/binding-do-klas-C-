using System;
using System.ComponentModel;

public class MediaItem : INotifyPropertyChanged
{
    private string title;
    private string directorOrAuthor;
    private string publisherOrStudio;
    private string medium;
    private TimeSpan length;
    private DateTime releaseDate;

    public string Title
    {
        get { return title; }
        set
        {
            title = value;
            OnPropertyChanged("Title");
        }
    }

    public string DirectorOrAuthor
    {
        get { return directorOrAuthor; }
        set
        {
            directorOrAuthor = value;
            OnPropertyChanged("DirectorOrAuthor");
        }
    }

    public string PublisherOrStudio
    {
        get { return publisherOrStudio; }
        set
        {
            publisherOrStudio = value;
            OnPropertyChanged("PublisherOrStudio");
        }
    }

    public string Medium
    {
        get { return medium; }
        set
        {
            medium = value;
            OnPropertyChanged("Medium");
        }
    }

    public string Length
    {
        get { return string.Format("{0}:{1}:{2}", length.Hours, length.Minutes, length.Seconds); }
        set
        {
            length = TimeSpan.Parse(value);
            OnPropertyChanged("Length");
        }
    }

    public DateTime ReleaseDate
    {
        get { return releaseDate; }
        set
        {
            releaseDate = value;
            OnPropertyChanged("ReleaseDate");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

