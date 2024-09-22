using System;

namespace Alacrity {

    public enum UnityKeyCode {
        None = 0,
        Backspace = 8,
        Delete = 127,
        Tab = 9,
        Clear = 12,
        Return = 13,
        Pause = 19,
        Escape = 27,
        Space = 32,
        Keypad0 = 256,
        Keypad1 = 257,
        Keypad2 = 258,
        Keypad3 = 259,
        Keypad4 = 260,
        Keypad5 = 261,
        Keypad6 = 262,
        Keypad7 = 263,
        Keypad8 = 264,
        Keypad9 = 265,
        KeypadPeriod = 266,
        KeypadDivide = 267,
        KeypadMultiply = 268,
        KeypadMinus = 269,
        KeypadPlus = 270,
        KeypadEnter = 271,
        KeypadEquals = 272,
        UpArrow = 273,
        DownArrow = 274,
        RightArrow = 275,
        LeftArrow = 276,
        Insert = 277,
        Home = 278,
        End = 279,
        PageUp = 280,
        PageDown = 281,
        F1 = 282,
        F2 = 283,
        F3 = 284,
        F4 = 285,
        F5 = 286,
        F6 = 287,
        F7 = 288,
        F8 = 289,
        F9 = 290,
        F10 = 291,
        F11 = 292,
        F12 = 293,
        F13 = 294,
        F14 = 295,
        F15 = 296,
        Alpha0 = 48,
        Alpha1 = 49,
        Alpha2 = 50,
        Alpha3 = 51,
        Alpha4 = 52,
        Alpha5 = 53,
        Alpha6 = 54,
        Alpha7 = 55,
        Alpha8 = 56,
        Alpha9 = 57,
        Exclaim = 33,
        DoubleQuote = 34,
        Hash = 35,
        Dollar = 36,
        Percent = 37,
        Ampersand = 38,
        Quote = 39,
        LeftParen = 40,
        RightParen = 41,
        Asterisk = 42,
        Plus = 43,
        Comma = 44,
        Minus = 45,
        Period = 46,
        Slash = 47,
        Colon = 58,
        Semicolon = 59,
        Less = 60,
        Equals = 61,
        Greater = 62,
        Question = 63,
        At = 64,
        LeftBracket = 91,
        Backslash = 92,
        RightBracket = 93,
        Caret = 94,
        Underscore = 95,
        BackQuote = 96,
        A = 97,
        B = 98,
        C = 99,
        D = 100,
        E = 101,
        F = 102,
        G = 103,
        H = 104,
        I = 105,
        J = 106,
        K = 107,
        L = 108,
        M = 109,
        N = 110,
        O = 111,
        P = 112,
        Q = 113,
        R = 114,
        S = 115,
        T = 116,
        U = 117,
        V = 118,
        W = 119,
        X = 120,
        Y = 121,
        Z = 122,
        LeftCurlyBracket = 123,
        Pipe = 124,
        RightCurlyBracket = 125,
        Tilde = 126,
        Numlock = 300,
        CapsLock = 301,
        ScrollLock = 302,
        RightShift = 303,
        LeftShift = 304,
        RightControl = 305,
        LeftControl = 306,
        RightAlt = 307,
        LeftAlt = 308,
        LeftMeta = 310,
        LeftCommand = 310,
        LeftApple = 310,
        LeftWindows = 311,
        RightMeta = 309,
        RightCommand = 309,
        RightApple = 309,
        RightWindows = 312,
        AltGr = 313,
        Help = 315,
        Print = 316,
        SysReq = 317,
        Break = 318,
        Menu = 319,
        Mouse0 = 323,
        Mouse1 = 324,
        Mouse2 = 325,
        Mouse3 = 326,
        Mouse4 = 327,
        Mouse5 = 328,
        Mouse6 = 329,
        JoystickButton0 = 330,
        JoystickButton1 = 331,
        JoystickButton2 = 332,
        JoystickButton3 = 333,
        JoystickButton4 = 334,
        JoystickButton5 = 335,
        JoystickButton6 = 336,
        JoystickButton7 = 337,
        JoystickButton8 = 338,
        JoystickButton9 = 339,
        JoystickButton10 = 340,
        JoystickButton11 = 341,
        JoystickButton12 = 342,
        JoystickButton13 = 343,
        JoystickButton14 = 344,
        JoystickButton15 = 345,
        JoystickButton16 = 346,
        JoystickButton17 = 347,
        JoystickButton18 = 348,
        JoystickButton19 = 349,
        Joystick1Button0 = 350,
        Joystick1Button1 = 351,
        Joystick1Button2 = 352,
        Joystick1Button3 = 353,
        Joystick1Button4 = 354,
        Joystick1Button5 = 355,
        Joystick1Button6 = 356,
        Joystick1Button7 = 357,
        Joystick1Button8 = 358,
        Joystick1Button9 = 359,
        Joystick1Button10 = 360,
        Joystick1Button11 = 361,
        Joystick1Button12 = 362,
        Joystick1Button13 = 363,
        Joystick1Button14 = 364,
        Joystick1Button15 = 365,
        Joystick1Button16 = 366,
        Joystick1Button17 = 367,
        Joystick1Button18 = 368,
        Joystick1Button19 = 369,
        Joystick2Button0 = 370,
        Joystick2Button1 = 371,
        Joystick2Button2 = 372,
        Joystick2Button3 = 373,
        Joystick2Button4 = 374,
        Joystick2Button5 = 375,
        Joystick2Button6 = 376,
        Joystick2Button7 = 377,
        Joystick2Button8 = 378,
        Joystick2Button9 = 379,
        Joystick2Button10 = 380,
        Joystick2Button11 = 381,
        Joystick2Button12 = 382,
        Joystick2Button13 = 383,
        Joystick2Button14 = 384,
        Joystick2Button15 = 385,
        Joystick2Button16 = 386,
        Joystick2Button17 = 387,
        Joystick2Button18 = 388,
        Joystick2Button19 = 389,
        Joystick3Button0 = 390,
        Joystick3Button1 = 391,
        Joystick3Button2 = 392,
        Joystick3Button3 = 393,
        Joystick3Button4 = 394,
        Joystick3Button5 = 395,
        Joystick3Button6 = 396,
        Joystick3Button7 = 397,
        Joystick3Button8 = 398,
        Joystick3Button9 = 399,
        Joystick3Button10 = 400,
        Joystick3Button11 = 401,
        Joystick3Button12 = 402,
        Joystick3Button13 = 403,
        Joystick3Button14 = 404,
        Joystick3Button15 = 405,
        Joystick3Button16 = 406,
        Joystick3Button17 = 407,
        Joystick3Button18 = 408,
        Joystick3Button19 = 409,
        Joystick4Button0 = 410,
        Joystick4Button1 = 411,
        Joystick4Button2 = 412,
        Joystick4Button3 = 413,
        Joystick4Button4 = 414,
        Joystick4Button5 = 415,
        Joystick4Button6 = 416,
        Joystick4Button7 = 417,
        Joystick4Button8 = 418,
        Joystick4Button9 = 419,
        Joystick4Button10 = 420,
        Joystick4Button11 = 421,
        Joystick4Button12 = 422,
        Joystick4Button13 = 423,
        Joystick4Button14 = 424,
        Joystick4Button15 = 425,
        Joystick4Button16 = 426,
        Joystick4Button17 = 427,
        Joystick4Button18 = 428,
        Joystick4Button19 = 429,
        Joystick5Button0 = 430,
        Joystick5Button1 = 431,
        Joystick5Button2 = 432,
        Joystick5Button3 = 433,
        Joystick5Button4 = 434,
        Joystick5Button5 = 435,
        Joystick5Button6 = 436,
        Joystick5Button7 = 437,
        Joystick5Button8 = 438,
        Joystick5Button9 = 439,
        Joystick5Button10 = 440,
        Joystick5Button11 = 441,
        Joystick5Button12 = 442,
        Joystick5Button13 = 443,
        Joystick5Button14 = 444,
        Joystick5Button15 = 445,
        Joystick5Button16 = 446,
        Joystick5Button17 = 447,
        Joystick5Button18 = 448,
        Joystick5Button19 = 449,
        Joystick6Button0 = 450,
        Joystick6Button1 = 451,
        Joystick6Button2 = 452,
        Joystick6Button3 = 453,
        Joystick6Button4 = 454,
        Joystick6Button5 = 455,
        Joystick6Button6 = 456,
        Joystick6Button7 = 457,
        Joystick6Button8 = 458,
        Joystick6Button9 = 459,
        Joystick6Button10 = 460,
        Joystick6Button11 = 461,
        Joystick6Button12 = 462,
        Joystick6Button13 = 463,
        Joystick6Button14 = 464,
        Joystick6Button15 = 465,
        Joystick6Button16 = 466,
        Joystick6Button17 = 467,
        Joystick6Button18 = 468,
        Joystick6Button19 = 469,
        Joystick7Button0 = 470,
        Joystick7Button1 = 471,
        Joystick7Button2 = 472,
        Joystick7Button3 = 473,
        Joystick7Button4 = 474,
        Joystick7Button5 = 475,
        Joystick7Button6 = 476,
        Joystick7Button7 = 477,
        Joystick7Button8 = 478,
        Joystick7Button9 = 479,
        Joystick7Button10 = 480,
        Joystick7Button11 = 481,
        Joystick7Button12 = 482,
        Joystick7Button13 = 483,
        Joystick7Button14 = 484,
        Joystick7Button15 = 485,
        Joystick7Button16 = 486,
        Joystick7Button17 = 487,
        Joystick7Button18 = 488,
        Joystick7Button19 = 489,
        Joystick8Button0 = 490,
        Joystick8Button1 = 491,
        Joystick8Button2 = 492,
        Joystick8Button3 = 493,
        Joystick8Button4 = 494,
        Joystick8Button5 = 495,
        Joystick8Button6 = 496,
        Joystick8Button7 = 497,
        Joystick8Button8 = 498,
        Joystick8Button9 = 499,
        Joystick8Button10 = 500,
        Joystick8Button11 = 501,
        Joystick8Button12 = 502,
        Joystick8Button13 = 503,
        Joystick8Button14 = 504,
        Joystick8Button15 = 505,
        Joystick8Button16 = 506,
        Joystick8Button17 = 507,
        Joystick8Button18 = 508,
        Joystick8Button19 = 509
    }

    // Pulled from https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
    public enum WindowsVirtualKeyCode {
        Mouse0 = 0x01,
        Mouse1 = 0x02,
        Cancel = 0x03,
        Mouse2 = 0x04,
        Mouse3 = 0x05,
        Mouse4 = 0x06,
        Backspace = 0x08,
        Tab = 0x09,
        Clear = 0x0C,
        Enter = 0x0D,
        Shift = 0x10,
        Control = 0x11,
        Alt = 0x12,
        Pause = 0x13,
        Caps = 0x14,
        Escape = 0x1B,
        Space = 0x20,
        PageUp = 0x21,
        PageDown = 0x22,
        End = 0x23,
        Home = 0x24,
        Left = 0x25,
        Up = 0x26,
        Right = 0x27,
        Down = 0x28,
        Select = 0x29,
        Print = 0x2A,
        Execute = 0x2B,
        PrintScreen = 0x2C,
        Insert = 0x2D,
        Delete = 0x2E,
        Help = 0x2F,

        Alpha0 = 0x30,
        Alpha1 = 0x31,
        Alpha2 = 0x32,
        Alpha3 = 0x33,
        Alpha4 = 0x34,
        Alpha5 = 0x35,
        Alpha6 = 0x36,
        Alpha7 = 0x37,
        Alpha8 = 0x38,
        Alpha9 = 0x39,

        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,

        Keypad0 = 0x60,
        Keypad1 = 0x61,
        Keypad2 = 0x62,
        Keypad3 = 0x63,
        Keypad4 = 0x64,
        Keypad5 = 0x65,
        Keypad6 = 0x66,
        Keypad7 = 0x67,
        Keypad8 = 0x68,
        Keypad9 = 0x69,

        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,

        LShift = 0xA0,
        RShift = 0xA1,
        LControl = 0xA2,
        RControl = 0xA3,
        LAlt = 0xA4,
        RAlt = 0xA5,

        Semicolon = 0xBA,
        Plus = 0xBB,
        Comma = 0xBC,
        Minus = 0xBD,
        Period = 0xBE,
        Slash = 0xBF,
        BackQuote = 0xC0,

        LeftBracket = 0xDB,
        Backslash = 0xDC,
        RightBracket = 0xDD,
        Quote = 0xDE,

        NumLock = 0x90,
        ScrollLock = 0x91,

        LeftWindows = 0x5B,
        RightWindows = 0x5C,

        KeypadMultiply = 0x6A,
        KeypadPlus = 0x6B,
        KeypadMinus = 0x6D,
        KeypadPeriod = 0x6E,
        KeypadDivide = 0x6F,
    }

    public class UnityKeyCodeMapping {

        public static WindowsVirtualKeyCode GetWindowsVirtualKeyForUnityKeyCode(UnityKeyCode unityKeyCode) {
            switch (unityKeyCode) {
                case UnityKeyCode.None:
                    // Nothing
                    return 0;
                case UnityKeyCode.Backspace:
                    return WindowsVirtualKeyCode.Backspace;
                case UnityKeyCode.Delete:
                    return WindowsVirtualKeyCode.Delete;
                case UnityKeyCode.Tab:
                    return WindowsVirtualKeyCode.Tab;
                case UnityKeyCode.Clear:
                    return WindowsVirtualKeyCode.Clear;
                case UnityKeyCode.Return:
                    return WindowsVirtualKeyCode.Enter;
                case UnityKeyCode.Pause:
                    return WindowsVirtualKeyCode.Pause;
                case UnityKeyCode.Escape:
                    return WindowsVirtualKeyCode.Escape;
                case UnityKeyCode.Space:
                    return WindowsVirtualKeyCode.Space;
                case UnityKeyCode.Keypad0:
                    return WindowsVirtualKeyCode.Keypad0;
                case UnityKeyCode.Keypad1:
                    return WindowsVirtualKeyCode.Keypad1;
                case UnityKeyCode.Keypad2:
                    return WindowsVirtualKeyCode.Keypad2;
                case UnityKeyCode.Keypad3:
                    return WindowsVirtualKeyCode.Keypad3;
                case UnityKeyCode.Keypad4:
                    return WindowsVirtualKeyCode.Keypad4;
                case UnityKeyCode.Keypad5:
                    return WindowsVirtualKeyCode.Keypad5;
                case UnityKeyCode.Keypad6:
                    return WindowsVirtualKeyCode.Keypad6;
                case UnityKeyCode.Keypad7:
                    return WindowsVirtualKeyCode.Keypad7;
                case UnityKeyCode.Keypad8:
                    return WindowsVirtualKeyCode.Keypad8;
                case UnityKeyCode.Keypad9:
                    return WindowsVirtualKeyCode.Keypad9;

                case UnityKeyCode.UpArrow:
                    return WindowsVirtualKeyCode.Up;

                case UnityKeyCode.DownArrow:
                    return WindowsVirtualKeyCode.Down;
                case UnityKeyCode.RightArrow:
                    return WindowsVirtualKeyCode.Right;
                case UnityKeyCode.LeftArrow:
                    return WindowsVirtualKeyCode.Left;

                case UnityKeyCode.Insert:
                    return WindowsVirtualKeyCode.Insert;
                case UnityKeyCode.Home:
                    return WindowsVirtualKeyCode.Home;
                case UnityKeyCode.End:
                    return WindowsVirtualKeyCode.End;
                case UnityKeyCode.PageUp:
                    return WindowsVirtualKeyCode.PageUp;
                case UnityKeyCode.PageDown:
                    return WindowsVirtualKeyCode.PageDown;

                case UnityKeyCode.A:
                    return WindowsVirtualKeyCode.A;
                case UnityKeyCode.B:
                    return WindowsVirtualKeyCode.B;
                case UnityKeyCode.C:
                    return WindowsVirtualKeyCode.C;
                case UnityKeyCode.D:
                    return WindowsVirtualKeyCode.D;
                case UnityKeyCode.E:
                    return WindowsVirtualKeyCode.E;
                case UnityKeyCode.F:
                    return WindowsVirtualKeyCode.F;
                case UnityKeyCode.G:
                    return WindowsVirtualKeyCode.G;
                case UnityKeyCode.H:
                    return WindowsVirtualKeyCode.H;
                case UnityKeyCode.I:
                    return WindowsVirtualKeyCode.I;
                case UnityKeyCode.J:
                    return WindowsVirtualKeyCode.J;
                case UnityKeyCode.K:
                    return WindowsVirtualKeyCode.K;
                case UnityKeyCode.L:
                    return WindowsVirtualKeyCode.L;
                case UnityKeyCode.M:
                    return WindowsVirtualKeyCode.M;
                case UnityKeyCode.N:
                    return WindowsVirtualKeyCode.N;
                case UnityKeyCode.O:
                    return WindowsVirtualKeyCode.O;
                case UnityKeyCode.P:
                    return WindowsVirtualKeyCode.P;
                case UnityKeyCode.Q:
                    return WindowsVirtualKeyCode.Q;
                case UnityKeyCode.R:
                    return WindowsVirtualKeyCode.R;
                case UnityKeyCode.S:
                    return WindowsVirtualKeyCode.S;
                case UnityKeyCode.T:
                    return WindowsVirtualKeyCode.T;
                case UnityKeyCode.U:
                    return WindowsVirtualKeyCode.U;
                case UnityKeyCode.V:
                    return WindowsVirtualKeyCode.V;
                case UnityKeyCode.W:
                    return WindowsVirtualKeyCode.W;
                case UnityKeyCode.X:
                    return WindowsVirtualKeyCode.X;
                case UnityKeyCode.Y:
                    return WindowsVirtualKeyCode.Y;
                case UnityKeyCode.Z:
                    return WindowsVirtualKeyCode.Z;


                case UnityKeyCode.F1:
                    return WindowsVirtualKeyCode.F1;
                case UnityKeyCode.F2:
                    return WindowsVirtualKeyCode.F2;
                case UnityKeyCode.F3:
                    return WindowsVirtualKeyCode.F3;
                case UnityKeyCode.F4:
                    return WindowsVirtualKeyCode.F4;
                case UnityKeyCode.F5:
                    return WindowsVirtualKeyCode.F5;
                case UnityKeyCode.F6:
                    return WindowsVirtualKeyCode.F6;
                case UnityKeyCode.F7:
                    return WindowsVirtualKeyCode.F7;
                case UnityKeyCode.F8:
                    return WindowsVirtualKeyCode.F8;
                case UnityKeyCode.F9:
                    return WindowsVirtualKeyCode.F9;
                case UnityKeyCode.F10:
                    return WindowsVirtualKeyCode.F10;
                case UnityKeyCode.F11:
                    return WindowsVirtualKeyCode.F11;
                case UnityKeyCode.F12:
                    return WindowsVirtualKeyCode.F12;
                case UnityKeyCode.F13:
                    return WindowsVirtualKeyCode.F13;
                case UnityKeyCode.F14:
                    return WindowsVirtualKeyCode.F14;
                case UnityKeyCode.F15:
                    return WindowsVirtualKeyCode.F15;

                case UnityKeyCode.Alpha0:
                    return WindowsVirtualKeyCode.Alpha0;
                case UnityKeyCode.Alpha1:
                    return WindowsVirtualKeyCode.Alpha1;
                case UnityKeyCode.Alpha2:
                    return WindowsVirtualKeyCode.Alpha2;
                case UnityKeyCode.Alpha3:
                    return WindowsVirtualKeyCode.Alpha3;
                case UnityKeyCode.Alpha4:
                    return WindowsVirtualKeyCode.Alpha4;
                case UnityKeyCode.Alpha5:
                    return WindowsVirtualKeyCode.Alpha5;
                case UnityKeyCode.Alpha6:
                    return WindowsVirtualKeyCode.Alpha6;
                case UnityKeyCode.Alpha7:
                    return WindowsVirtualKeyCode.Alpha7;
                case UnityKeyCode.Alpha8:
                    return WindowsVirtualKeyCode.Alpha8;
                case UnityKeyCode.Alpha9:
                    return WindowsVirtualKeyCode.Alpha9;

                case UnityKeyCode.RightShift:
                    return WindowsVirtualKeyCode.Shift;
                case UnityKeyCode.LeftShift:
                    return WindowsVirtualKeyCode.Shift;
                case UnityKeyCode.RightControl:
                    return WindowsVirtualKeyCode.Control;
                case UnityKeyCode.LeftControl:
                    return WindowsVirtualKeyCode.Control;
                case UnityKeyCode.RightAlt:
                    return WindowsVirtualKeyCode.Alt;
                case UnityKeyCode.LeftAlt:
                    return WindowsVirtualKeyCode.Alt;

                case UnityKeyCode.Quote:
                    return WindowsVirtualKeyCode.Quote;
                case UnityKeyCode.Comma:
                    return WindowsVirtualKeyCode.Comma;
                case UnityKeyCode.Minus:
                    return WindowsVirtualKeyCode.Minus;
                case UnityKeyCode.Period:
                    return WindowsVirtualKeyCode.Period;
                case UnityKeyCode.Slash:
                    return WindowsVirtualKeyCode.Slash;
                case UnityKeyCode.Semicolon:
                    return WindowsVirtualKeyCode.Semicolon;
                case UnityKeyCode.Equals:
                    // Apparently equals is shared with plus: https://stackoverflow.com/questions/45961154/what-is-virtual-key-code-for
                    return WindowsVirtualKeyCode.Plus;
                case UnityKeyCode.LeftBracket:
                    return WindowsVirtualKeyCode.LeftBracket;
                case UnityKeyCode.Backslash:
                    return WindowsVirtualKeyCode.Backslash;
                case UnityKeyCode.RightBracket:
                    return WindowsVirtualKeyCode.RightBracket;
                case UnityKeyCode.BackQuote:
                    return WindowsVirtualKeyCode.BackQuote;

                case UnityKeyCode.Numlock:
                    return WindowsVirtualKeyCode.NumLock;
                case UnityKeyCode.CapsLock:
                    return WindowsVirtualKeyCode.Caps;
                case UnityKeyCode.ScrollLock:
                    return WindowsVirtualKeyCode.ScrollLock;

                case UnityKeyCode.KeypadPeriod:
                    return WindowsVirtualKeyCode.KeypadPeriod;
                case UnityKeyCode.KeypadDivide:
                    return WindowsVirtualKeyCode.KeypadDivide;
                case UnityKeyCode.KeypadMultiply:
                    return WindowsVirtualKeyCode.KeypadMultiply;
                case UnityKeyCode.KeypadMinus:
                    return WindowsVirtualKeyCode.KeypadMinus;
                case UnityKeyCode.KeypadPlus:
                    return WindowsVirtualKeyCode.KeypadPlus;
                case UnityKeyCode.KeypadEnter:
                    return WindowsVirtualKeyCode.Enter;

                case UnityKeyCode.LeftMeta:
                case UnityKeyCode.RightMeta:
                case UnityKeyCode.Print:
                    return WindowsVirtualKeyCode.Print;

                // Mouse events shouldnt send a key event
                case UnityKeyCode.Mouse0:
                case UnityKeyCode.Mouse1:
                case UnityKeyCode.Mouse2:
                case UnityKeyCode.Mouse3:
                case UnityKeyCode.Mouse4:

                // Unknown mapping
                case UnityKeyCode.KeypadEquals:
                case UnityKeyCode.Menu:
                case UnityKeyCode.JoystickButton0:
                case UnityKeyCode.JoystickButton1:
                case UnityKeyCode.JoystickButton2:
                case UnityKeyCode.JoystickButton3:
                case UnityKeyCode.JoystickButton4:
                case UnityKeyCode.JoystickButton5:
                case UnityKeyCode.JoystickButton6:
                case UnityKeyCode.JoystickButton7:
                case UnityKeyCode.JoystickButton8:
                case UnityKeyCode.JoystickButton9:
                case UnityKeyCode.JoystickButton10:
                case UnityKeyCode.JoystickButton11:
                case UnityKeyCode.JoystickButton12:
                case UnityKeyCode.JoystickButton13:
                case UnityKeyCode.JoystickButton14:
                case UnityKeyCode.JoystickButton15:
                case UnityKeyCode.JoystickButton16:
                case UnityKeyCode.JoystickButton17:
                case UnityKeyCode.JoystickButton18:
                case UnityKeyCode.JoystickButton19:
                case UnityKeyCode.Joystick1Button0:
                case UnityKeyCode.Joystick1Button1:
                case UnityKeyCode.Joystick1Button2:
                case UnityKeyCode.Joystick1Button3:
                case UnityKeyCode.Joystick1Button4:
                case UnityKeyCode.Joystick1Button5:
                case UnityKeyCode.Joystick1Button6:
                case UnityKeyCode.Joystick1Button7:
                case UnityKeyCode.Joystick1Button8:
                case UnityKeyCode.Joystick1Button9:
                case UnityKeyCode.Joystick1Button10:
                case UnityKeyCode.Joystick1Button11:
                case UnityKeyCode.Joystick1Button12:
                case UnityKeyCode.Joystick1Button13:
                case UnityKeyCode.Joystick1Button14:
                case UnityKeyCode.Joystick1Button15:
                case UnityKeyCode.Joystick1Button16:
                case UnityKeyCode.Joystick1Button17:
                case UnityKeyCode.Joystick1Button18:
                case UnityKeyCode.Joystick1Button19:
                case UnityKeyCode.Joystick2Button0:
                case UnityKeyCode.Joystick2Button1:
                case UnityKeyCode.Joystick2Button2:
                case UnityKeyCode.Joystick2Button3:
                case UnityKeyCode.Joystick2Button4:
                case UnityKeyCode.Joystick2Button5:
                case UnityKeyCode.Joystick2Button6:
                case UnityKeyCode.Joystick2Button7:
                case UnityKeyCode.Joystick2Button8:
                case UnityKeyCode.Joystick2Button9:
                case UnityKeyCode.Joystick2Button10:
                case UnityKeyCode.Joystick2Button11:
                case UnityKeyCode.Joystick2Button12:
                case UnityKeyCode.Joystick2Button13:
                case UnityKeyCode.Joystick2Button14:
                case UnityKeyCode.Joystick2Button15:
                case UnityKeyCode.Joystick2Button16:
                case UnityKeyCode.Joystick2Button17:
                case UnityKeyCode.Joystick2Button18:
                case UnityKeyCode.Joystick2Button19:
                case UnityKeyCode.Joystick3Button0:
                case UnityKeyCode.Joystick3Button1:
                case UnityKeyCode.Joystick3Button2:
                case UnityKeyCode.Joystick3Button3:
                case UnityKeyCode.Joystick3Button4:
                case UnityKeyCode.Joystick3Button5:
                case UnityKeyCode.Joystick3Button6:
                case UnityKeyCode.Joystick3Button7:
                case UnityKeyCode.Joystick3Button8:
                case UnityKeyCode.Joystick3Button9:
                case UnityKeyCode.Joystick3Button10:
                case UnityKeyCode.Joystick3Button11:
                case UnityKeyCode.Joystick3Button12:
                case UnityKeyCode.Joystick3Button13:
                case UnityKeyCode.Joystick3Button14:
                case UnityKeyCode.Joystick3Button15:
                case UnityKeyCode.Joystick3Button16:
                case UnityKeyCode.Joystick3Button17:
                case UnityKeyCode.Joystick3Button18:
                case UnityKeyCode.Joystick3Button19:
                case UnityKeyCode.Joystick4Button0:
                case UnityKeyCode.Joystick4Button1:
                case UnityKeyCode.Joystick4Button2:
                case UnityKeyCode.Joystick4Button3:
                case UnityKeyCode.Joystick4Button4:
                case UnityKeyCode.Joystick4Button5:
                case UnityKeyCode.Joystick4Button6:
                case UnityKeyCode.Joystick4Button7:
                case UnityKeyCode.Joystick4Button8:
                case UnityKeyCode.Joystick4Button9:
                case UnityKeyCode.Joystick4Button10:
                case UnityKeyCode.Joystick4Button11:
                case UnityKeyCode.Joystick4Button12:
                case UnityKeyCode.Joystick4Button13:
                case UnityKeyCode.Joystick4Button14:
                case UnityKeyCode.Joystick4Button15:
                case UnityKeyCode.Joystick4Button16:
                case UnityKeyCode.Joystick4Button17:
                case UnityKeyCode.Joystick4Button18:
                case UnityKeyCode.Joystick4Button19:
                case UnityKeyCode.Joystick5Button0:
                case UnityKeyCode.Joystick5Button1:
                case UnityKeyCode.Joystick5Button2:
                case UnityKeyCode.Joystick5Button3:
                case UnityKeyCode.Joystick5Button4:
                case UnityKeyCode.Joystick5Button5:
                case UnityKeyCode.Joystick5Button6:
                case UnityKeyCode.Joystick5Button7:
                case UnityKeyCode.Joystick5Button8:
                case UnityKeyCode.Joystick5Button9:
                case UnityKeyCode.Joystick5Button10:
                case UnityKeyCode.Joystick5Button11:
                case UnityKeyCode.Joystick5Button12:
                case UnityKeyCode.Joystick5Button13:
                case UnityKeyCode.Joystick5Button14:
                case UnityKeyCode.Joystick5Button15:
                case UnityKeyCode.Joystick5Button16:
                case UnityKeyCode.Joystick5Button17:
                case UnityKeyCode.Joystick5Button18:
                case UnityKeyCode.Joystick5Button19:
                case UnityKeyCode.Joystick6Button0:
                case UnityKeyCode.Joystick6Button1:
                case UnityKeyCode.Joystick6Button2:
                case UnityKeyCode.Joystick6Button3:
                case UnityKeyCode.Joystick6Button4:
                case UnityKeyCode.Joystick6Button5:
                case UnityKeyCode.Joystick6Button6:
                case UnityKeyCode.Joystick6Button7:
                case UnityKeyCode.Joystick6Button8:
                case UnityKeyCode.Joystick6Button9:
                case UnityKeyCode.Joystick6Button10:
                case UnityKeyCode.Joystick6Button11:
                case UnityKeyCode.Joystick6Button12:
                case UnityKeyCode.Joystick6Button13:
                case UnityKeyCode.Joystick6Button14:
                case UnityKeyCode.Joystick6Button15:
                case UnityKeyCode.Joystick6Button16:
                case UnityKeyCode.Joystick6Button17:
                case UnityKeyCode.Joystick6Button18:
                case UnityKeyCode.Joystick6Button19:
                case UnityKeyCode.Joystick7Button0:
                case UnityKeyCode.Joystick7Button1:
                case UnityKeyCode.Joystick7Button2:
                case UnityKeyCode.Joystick7Button3:
                case UnityKeyCode.Joystick7Button4:
                case UnityKeyCode.Joystick7Button5:
                case UnityKeyCode.Joystick7Button6:
                case UnityKeyCode.Joystick7Button7:
                case UnityKeyCode.Joystick7Button8:
                case UnityKeyCode.Joystick7Button9:
                case UnityKeyCode.Joystick7Button10:
                case UnityKeyCode.Joystick7Button11:
                case UnityKeyCode.Joystick7Button12:
                case UnityKeyCode.Joystick7Button13:
                case UnityKeyCode.Joystick7Button14:
                case UnityKeyCode.Joystick7Button15:
                case UnityKeyCode.Joystick7Button16:
                case UnityKeyCode.Joystick7Button17:
                case UnityKeyCode.Joystick7Button18:
                case UnityKeyCode.Joystick7Button19:
                case UnityKeyCode.Joystick8Button0:
                case UnityKeyCode.Joystick8Button1:
                case UnityKeyCode.Joystick8Button2:
                case UnityKeyCode.Joystick8Button3:
                case UnityKeyCode.Joystick8Button4:
                case UnityKeyCode.Joystick8Button5:
                case UnityKeyCode.Joystick8Button6:
                case UnityKeyCode.Joystick8Button7:
                case UnityKeyCode.Joystick8Button8:
                case UnityKeyCode.Joystick8Button9:
                case UnityKeyCode.Joystick8Button10:
                case UnityKeyCode.Joystick8Button11:
                case UnityKeyCode.Joystick8Button12:
                case UnityKeyCode.Joystick8Button13:
                case UnityKeyCode.Joystick8Button14:
                case UnityKeyCode.Joystick8Button15:
                case UnityKeyCode.Joystick8Button16:
                case UnityKeyCode.Joystick8Button17:
                case UnityKeyCode.Joystick8Button18:
                case UnityKeyCode.Joystick8Button19:
                    throw new System.Exception($"Recieved unmapped unity keycode: {unityKeyCode}");
            }

            throw new System.Exception($"Recieved unmapped unity keycode: {unityKeyCode}");
        }

        public static int GetWindowsVirtualKeyForUnityKeyCodeAsInt(UnityKeyCode unityKeyCode) {
            try {
                return (int) GetWindowsVirtualKeyForUnityKeyCode(unityKeyCode);
            } catch (Exception) {
                return 0;
            }
        }

    }
}