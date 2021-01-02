*Chabrier Julien* - *Clochard Amaury* - *Nivoix Thomas* - *Soytürk Ilker* - *Villechenaud Simon* / **S2D**
# README du projet
## Introduction
Notre groupe a développé  une application de gestion de discothèque, dans lequel nous avons un espace "Connexion", "Abonnement", "Abonné" et "Administrateur". Ce projet a été dirigé en méthode SCRUM. Toutes les `User Stories` ont été réalisées sous les 2 technologies, `Entity Framework` et `OleDB`. La version framework utilisée pour la réalisation du projet est `.NET Framework v4.7.1`.

## Paramétrage de l'application
Sous la techno `Entity Framework`, dans le fichier App.config nous devons mettre le nom du serveur utilisé dans l'emplacement indiqué :
```
data source=NOM_DU_SERVEUR;
```

Sous la techno `OleDB`, dans le fichier Source.cs nous devons mettre le nom du serveur utilisé dans l'emplacement indiqué :
```cs
public static string ChaineBD = "Provider=SQLOLEDB;Data Source=NOM_DU_SERVEUR;Initial Catalog=MusiqueSQL;Integrated Security=SSPI;";
```

## Espace de Connexion
Dans cette fenêtre il est possible de se connecter si un compte existe déjà dans la base de données, sinon il est invité à s'abonner dans la fenêtre d'abonnement. Si l'utilisateur se connecte avec "`admin`" en login et "`admin`" en mot de passe, il est redirigé vers l'espace Administrateur.
## Espace d'Abonnement
Permet de créer un nouvel abonné dans la base. Notre application ne permet pas d'avoir des champs vides. Dans la même logique la base de données de doit pas comprendre de valeurs nulles, auquel cas une erreur est engendré par l'application. Pour les logins il y plusieurs restrictions :
* Login déjà existant rejeté
* Login contenant un espace rejeté
* Login vide rejeté
* Login "`admin`" rejeté
## Espace Abonné
- Permet de consulter les albums disponibles et de les emprunter. 
- Permet de consulter les albums empruntés de l'abonné courant et de :
     - rendre un album ( boîte de dialogue)
     - prolonger l'emprunt d'un mois d'un album
     - prolonger l'emprunt d'un mois de tous les albums 
- Se déconnecter
## Espace Administrateur
- Voir le top 10 des albums empruntés
- Voir les abonnés ayant 10 jours de retard sur un emprunt
- Voir les emprunts en cours
- Voir les abonnés inactifs depuis un an et les supprimer si nécessaire

