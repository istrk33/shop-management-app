//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emprunter
    {
        public int Code_Abonné { get; set; }
        public int Code_Album { get; set; }
        public Nullable<System.DateTime> Date_Emprunt { get; set; }
        public Nullable<System.DateTime> Date_Retour { get; set; }
    
        public virtual Abonné Abonné { get; set; }
        public virtual Album Album { get; set; }
    }
}
