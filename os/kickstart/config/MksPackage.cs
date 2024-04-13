using System.Collections.Generic;

namespace markisa.foundation
{

/// <summary>
/// Represents some application bullshit
/// </summary>
public struct MksPackage
{
    /// <summary>
    /// The display names for each language the app supports, with the key being a code like "en" or "pt" or "es" or "ru"
    /// </summary>
    public Dictionary<string, string> DisplayNames { get; set; }
    /// <summary>
    /// Who made this app
    /// </summary>
    public string Author { get; set; }
    /// <summary>
    /// A path to the icon of this app
    /// </summary>
    public string Icon { get; set; }
    /// <summary>
    /// A path to the scene with the app, with a MksWindow as its root.
    /// </summary>
    public string Executable { get; set; }
    /// <summary>
    /// A path to the scene with the uninstaller for this app. If set to "", this app cannot be uninstalled.
    /// </summary>
    public string Uninstaller { get; set; }
    public Categories[] AppCategories { get; set; }

    public enum Categories
    {
        /// <summary>
        /// Basically categorizing apps as "Other"
        /// </summary>
        Accessories,
        /// <summary>
        /// Apps used for modding and stuff.
        /// </summary>
        Development,
        /// <summary>
        /// Videogames.
        /// </summary>
        Games,
        /// <summary>
        /// Apps used for doing stuff with graphics.
        /// </summary>
        Graphics,
        /// <summary>
        /// Apps related to the world wide web.
        /// </summary>
        Internet,
        /// <summary>
        /// Apps that do stuff with media.
        /// </summary>
        Multimedia,
        /// <summary>
        /// Apps used in offices and stuff.
        /// </summary>
        Office,
        /// <summary>
        /// Apps that come with the system or something.
        /// </summary>
        System,
        /// <summary>
        /// Very small apps like a calculator and a photo viewer.
        /// </summary>
        Utilities
    }
}

}