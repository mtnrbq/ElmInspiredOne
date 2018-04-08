namespace ElmInspiredOneXF.Droid
open System

open Android.App
open Android.Content
open Android.Content.PM
open Android.Runtime
open Android.Views
open Android.Widget
open Android.OS
open ElmInspiredXF
open Gjallarhorn.XamarinForms
open ElmInspiredOne.Program
open Xamarin.Forms.Platform.Android

[<Activity(Label = "Elm Inspired One", MainLauncher = true, Icon = "@drawable/icon")>]
type MainActivity() =
    inherit Xamarin.Forms.Platform.Android.FormsApplicationActivity()
    override this.OnCreate (bundle: Bundle) =
        base.OnCreate (bundle)

        Xamarin.Forms.Forms.Init (this, bundle)
        let info = Framework.createApplicationInfo ElmInspiredOne.Program.applicationCore  (new MainPage()) 
        this.LoadApplication(info.CreateApp())

