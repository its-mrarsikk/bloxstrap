> [!CAUTION]
> The only official place to download its-mrarsikk's Bloxstrap fork is this GitHub repository. Any other websites offering downloads or claiming to be me are not controlled by me.

<p align="center">
    <img src="https://github.com/pizzaboxer/bloxstrap/raw/main/Images/Bloxstrap-full-dark.png#gh-dark-mode-only" width="420">
    <img src="https://github.com/pizzaboxer/bloxstrap/raw/main/Images/Bloxstrap-full-light.png#gh-light-mode-only" width="420">
</p>

<div align="center">

[![License][shield-repo-license]][repo-license]
[![Downloads][shield-repo-releases]][repo-releases]
[![Version][shield-repo-latest]][repo-latest]
[![lol][shield-tenor-meme]][tenor-gif]

</div>

----

This is a fork of pizzaboxer's Bloxstrap with some additional features.

Running into a problem or need help with something? [Check out the Wiki](https://github.com/its-mrarsikk/bloxstrap/wiki). If you can't find anything, or would like to suggest something, please [submit an issue](https://github.com/its-mrarsikk/bloxstrap/issues).

Bloxstrap is only supported for PCs running Windows.

> [!NOTE]
> **For help on the majority of Bloxstrap, go to [the original repo](https://github.com/bloxstraplabs/bloxstrap). I only maintain a small amount of additional features.**
> The wiki here only documents the features unique to the fork. If the problem you report with an issue is not caused by my code, you will be redirected to [the official repo's issues](https://github.com/bloxstraplabs/bloxstrap/issues).

## Features

- Changing the escape menu version (It was removed in [Bloxstrap 2.8.1](https://github.com/bloxstraplabs/bloxstrap/releases/tag/v2.8.1))
- Customizable group ID for GUI hiding
- All the features from [Bloxstrap](https://github.com/bloxstraplabs/bloxstrap)
- That's it for now.

## Installing
Download the [latest release of Bloxstrap](https://github.com/its-mrarsikk/bloxstrap/releases/latest), and run it. Configure your preferences if needed, and install. That's about it!

This fork of Bloxstrap is not planned to be on Winget in the near future.

You will also need the [.NET 6 Desktop Runtime](https://aka.ms/dotnet-core-applaunch?missing_runtime=true&arch=x64&rid=win11-x64&apphost_version=6.0.16&gui=true). If you don't already have it installed, you'll be prompted to install it anyway. Be sure to install Bloxstrap after you've installed this.

It's not unlikely that Windows Smartscreen will show a popup when you run Bloxstrap for the first time. This happens because it's an unknown program, not because it's actually detected as being malicious. To dismiss it, just click on "More info" and then "Run anyway".

Once installed, Bloxstrap is added to your Start Menu, where you can access the menu and reconfigure your preferences if needed.

## Known Issues
- When installing regular Bloxstrap on top of the fork, it throws the following exception: 

    ![386630042-c583eaf4-eddd-4817-bd66-edf62f619a9b](https://github.com/user-attachments/assets/6a000898-bbbd-49b7-8380-436334b85677)

    It doesn't seem to impact functionality.

## Code

Bloxstrap uses the [WPF UI](https://github.com/lepoco/wpfui) library for the user interface design. Bloxstrap and this fork currently use and maintain a custom fork of WPF UI at [bloxstraplabs/wpfui](https://github.com/bloxstraplabs/wpfui).

[shield-repo-license]:  https://img.shields.io/github/license/its-mrarsikk/bloxstrap
[shield-repo-releases]: https://img.shields.io/github/downloads/its-mrarsikk/bloxstrap/latest/total?color=981bfe
[shield-repo-latest]:   https://img.shields.io/github/v/release/its-mrarsikk/bloxstrap?color=7a39fb

[shield-tenor-meme]:     https://img.shields.io/badge/i_don't_know-what_i'm_doing-red?style=flat

[repo-license]:  https://github.com/its-mrarsikk/bloxstrap/blob/main/LICENSE
[repo-releases]: https://github.com/its-mrarsikk/bloxstrap/releases
[repo-latest]:   https://github.com/its-mrarsikk/bloxstrap/releases/latest

[tenor-gif]:       https://media.tenor.com/YcDveQiIWf4AAAAd/roblox-explosion.gif
