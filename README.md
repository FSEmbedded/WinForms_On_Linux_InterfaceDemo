# WinForms_On_Linux_InterfaceDemo
This is a small demo application with WinForms UI using hardware interfaces, which can also run under Linux with Mono

The application is written for F&S boards with ARM32 processor and Windows CE 2013. It interacts with hardware interfaces using the F&S APIs: [Software .NET Drivers](https://www.fs-net.de/en/embedded-modules/accessories/software-net-drivers/).
You can build it in Visual Studio 2015, using the SDK for your board. See this documentation: [https://www.fs-net.de/assets/download/docu/picocom/PicoCOMA5/PicoCOMA5_FirstSteps_WCE.pdf]

# Run this software on Linux
With [Mono](https://www.mono-project.com/) installed on your Linux device, you can run this WinForms app under Linux. Replace the APIs with the Linux-specific ones:

[NativeSPI-V1 for Linux](https://github.com/FSEmbedded/NativeSPI-V1_Linux)
[NativeI2C for Linux](https://github.com/FSEmbedded/NativeI2C_Linux)

You also need a [library](https://github.com/FSEmbedded/dotnet_linux_IO_API) that replaces ***coredll.dll***.