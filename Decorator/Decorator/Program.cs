using System;

namespace Decorator
{
    public interface IMediaPlayer
    {
        int SeekTime { get; }
        bool IsReady { get; }
        void Init();
        void Play();
    }

    public class VideoMediaPlayer : IMediaPlayer
    {
        private readonly string _url;
        private int _seekTime;

        public VideoMediaPlayer(string url, int seekTime)
        {
            _url = url;
            _seekTime = seekTime;
        }

        public int SeekTime => _seekTime;
        public bool IsReady { get; private set; }

        public void Init()
        {
            //Player prepare
            IsReady = true;
        }

        public void Play()
        {
            //Play video from url
        }
    }

    public class DoubleSidedVideoPlayer : IMediaPlayer
    {
        private readonly string _url1;
        private readonly string _url2;
        private int _seekTime;
        public int SeekTime => _seekTime;
        public bool IsReady { get; private set; }

        private IMediaPlayer player1;
        private IMediaPlayer player2;


        public DoubleSidedVideoPlayer(string url1, string url2, int seekTime)
        {
            _url1 = url1;
            _url2 = url2;
            _seekTime = seekTime;
        }

        public void Init()
        {
            player1 = new VideoMediaPlayer(_url1, _seekTime);
            player2 = new VideoMediaPlayer(_url2, _seekTime);

            player1.Init();
            player2.Init();

            IsReady = player1.IsReady && player2.IsReady;
        }

        public void Play()
        {
            player1.Play();
            player2.Play();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IMediaPlayer mediaPlayer = new DoubleSidedVideoPlayer("url1", "url1", 2);
            mediaPlayer.Init();
            mediaPlayer.Play();
            
            
            
            IBase _base = new Decorator();
            var a = new BaseDecorator(_base);
            a.GetSomething();
            Console.WriteLine();

            a = new ConcreteDecorator1(a);
            a.GetSomething();
            Console.WriteLine();

            a = new ConcreteDecorator2(a);
            a.GetSomething();
            Console.WriteLine();
        }
    }


    public interface IBase
    {
        public void GetSomething();
    }

    public class Decorator : IBase
    {
        public void GetSomething()
        {
            Console.WriteLine("decorator");
        }
    }

    public class BaseDecorator : Decorator
    {
        private IBase _base;

        public BaseDecorator(IBase _base)
        {
            this._base = _base;
        }

        public virtual void GetSomething()
        {
            _base.GetSomething();
            Console.WriteLine("Adding new decorator called BaseDecorator!");
        }
    }

    public class ConcreteDecorator1 : BaseDecorator
    {
        public ConcreteDecorator1(IBase _base) : base(_base)
        {
        }

        public override void GetSomething()
        {
            base.GetSomething();
            Console.WriteLine("Adding new decorator called ConcreteDecorator1!");
        }
    }

    public class ConcreteDecorator2 : ConcreteDecorator1
    {
        public ConcreteDecorator2(IBase _base) : base(_base)
        {
        }

        public override void GetSomething()
        {
            base.GetSomething();
            Console.WriteLine("Adding new decorator called ConcreteDecorator2!");
        }
    }
}