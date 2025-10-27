# 🎬 VIDEOR PLAYER 2015

**VIDEOR PLAYER 2015** is a Windows desktop video player built using **C# (.NET Framework)** and **Windows Media Player SDK**.  
It allows users to play, pause, stop, and manage video files with a simple and intuitive interface.

---

## ✨ Features

- ▶️ Play, pause, stop, and seek video playback  
- 📂 Load local media files (MP4, AVI, WMV, etc.)  
- 🔊 Adjust volume and mute/unmute audio  
- 🧭 Track playback progress and control via UI buttons  
- 🪟 Simple, lightweight Windows Forms interface  
- 💽 Uses built-in Windows Media Player controls  

---

## 🧰 Technologies Used

- **Language:** C# (.NET Framework 4.0+)  
- **IDE:** Microsoft Visual Studio 2015+  
- **Libraries / Components:**  
  - `AxInterop.WMPLib.dll` — ActiveX interop for Windows Media Player  
  - `Interop.WMPLib.dll` — COM library for media player controls  

---

## 🗂️ Project Structure

```
VIDEOR-PLAYER 2015/
├── VIDEOR-PLAYER.sln              # Visual Studio solution file
├── VIDEOR-PLAYER/
│   ├── Program.cs                 # Application entry point
│   ├── Form1.cs                   # Main form logic
│   ├── Form1.Designer.cs          # UI layout definitions
│   ├── Form1.resx                 # Form resources
│   ├── Properties/
│   │   ├── AssemblyInfo.cs
│   │   ├── Resources.resx
│   │   └── Settings.settings
│   ├── bin/Debug/
│   │   ├── VIDEOR-PLAYER.exe
│   │   ├── AxInterop.WMPLib.dll
│   │   └── Interop.WMPLib.dll
│   └── App.config                 # Application configuration
└── UpgradeLog.htm                 # Visual Studio upgrade logs
```

---

## ▶️ How to Run

1. **Open the solution** in **Visual Studio**  
   ```
   VIDEOR-PLAYER.sln
   ```

2. **Build the project:**  
   - Press **Ctrl + Shift + B** or select **Build → Build Solution**

3. **Run the application:**  
   - Press **F5** or select **Debug → Start Debugging**

4. **Load a video file** using the **Open** option in the UI or drag & drop (if supported).

---

## 🧩 Main Components

| File | Description |
|------|--------------|
| `Program.cs` | Application entry point |
| `Form1.cs` | Core logic for media playback |
| `Form1.Designer.cs` | UI design layout |
| `AxInterop.WMPLib.dll` | Windows Media Player ActiveX integration |
| `Interop.WMPLib.dll` | COM interop for playback control |

---

## 🧠 Notes

- The project uses **Windows Media Player** — ensure WMP is installed on your system.  
- Designed for **Windows OS** only.  
- Can be extended to include playlists, equalizer controls, or subtitles.

---

## 💡 Future Improvements

- Add playlist and repeat/shuffle options  
- Include dark/light UI themes  
- Support full-screen mode toggle  
- Add drag & drop video loading  

---

## 📄 License

 [License](./LICENSE.md): Proprietary – Permission Required

---
