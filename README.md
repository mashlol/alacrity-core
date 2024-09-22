# Alacrity Core Binary

This is the core binary of
[Alacrity](https://assetstore.unity.com/packages/slug/272444), which runs CEF
itself. This is run by Unity whenever the game launches so that it works
seamlessly in the editor and in play mode. It simply receives keyboard, mouse,
and other events via an IPC pipe and forwards those to the CEF browser. It also
forwards back to Unity the CEF browser render information like the shared
texture handle.


# Building

You'll need to have purchased Alacrity in order to build this. It's expected
that this resides next to your Assets folder inside of a Unity project, and the
Assets folder has Alacrity at the root.

```
./build.sh
```

Building it should produce the Alacrity.mv file (which is a .exe binary renamed)
in your Assets/Alacrity/AlacrityCore folder.
