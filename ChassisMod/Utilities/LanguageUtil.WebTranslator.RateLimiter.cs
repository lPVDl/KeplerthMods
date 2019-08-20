using System;

namespace ChassisMod.Utilities
{
    partial class LanguageUtil
    {
        partial class WebTranslator
        {
            private sealed class RateLimiter
            {
                public bool CanUseNow
                {
                    get
                    {
                        if (_currentUses < _frameUses) return true;

                        var frame = Environment.TickCount / _frameLength;
                        if (frame != _currentFrame) return true;

                        return false;
                    }
                }

                private int _frameLength;
                private int _frameUses;
                private int _currentFrame;
                private int _currentUses;

                public RateLimiter(int frameLength, int frameUses)
                {
                    if (frameLength < 1) throw new ArgumentException("frameLength must be greater than zero");
                    if (frameUses < 1) throw new ArgumentException("frameUses must be greater than zero");

                    _frameUses = frameUses;
                    _frameLength = frameLength;
                    _currentFrame = Environment.TickCount / _frameLength;
                }

                public bool TryUse()
                {
                    var frame = Environment.TickCount / _frameLength;
                    if (frame != _currentFrame)
                    {
                        _currentFrame = frame;
                        _currentUses = 1;
                        return true;
                    }

                    if (_currentUses < _frameUses)
                    {
                        _currentUses++;
                        return true;
                    }

                    return false;
                }

                public void WaitForNextUse()
                {
                    if (_currentUses < _frameUses) return;

                    var tickCount = Environment.TickCount;
                    var frame = tickCount / _frameLength;
                    if (frame != _currentFrame) return;

                    System.Threading.Thread.Sleep(_frameLength);
                }
            }
        }
    }
}