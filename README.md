<a name='assembly'></a>
# mtg_lite

## Contents

- [ApplicationConfiguration](#T-mtg_lite-ApplicationConfiguration 'mtg_lite.ApplicationConfiguration')
  - [Initialize()](#M-mtg_lite-ApplicationConfiguration-Initialize 'mtg_lite.ApplicationConfiguration.Initialize')
- [BattlefieldDisplay](#T-mtg_lite-Views-UserControls-ZoneDisplays-BattlefieldDisplay 'mtg_lite.Views.UserControls.ZoneDisplays.BattlefieldDisplay')
  - [components](#F-mtg_lite-Views-UserControls-ZoneDisplays-BattlefieldDisplay-components 'mtg_lite.Views.UserControls.ZoneDisplays.BattlefieldDisplay.components')
  - [Dispose(disposing)](#M-mtg_lite-Views-UserControls-ZoneDisplays-BattlefieldDisplay-Dispose-System-Boolean- 'mtg_lite.Views.UserControls.ZoneDisplays.BattlefieldDisplay.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-mtg_lite-Views-UserControls-ZoneDisplays-BattlefieldDisplay-InitializeComponent 'mtg_lite.Views.UserControls.ZoneDisplays.BattlefieldDisplay.InitializeComponent')
- [BattlefieldManager](#T-mtg_lite-Models-Zones-BattlefieldManager 'mtg_lite.Models.Zones.BattlefieldManager')
  - [GetCards(handsName)](#M-mtg_lite-Models-Zones-BattlefieldManager-GetCards-System-String- 'mtg_lite.Models.Zones.BattlefieldManager.GetCards(System.String)')
- [CardDisplay](#T-mtg_lite-Views-UserControls-CardDisplays-CardDisplay 'mtg_lite.Views.UserControls.CardDisplays.CardDisplay')
  - [components](#F-mtg_lite-Views-UserControls-CardDisplays-CardDisplay-components 'mtg_lite.Views.UserControls.CardDisplays.CardDisplay.components')
  - [Dispose(disposing)](#M-mtg_lite-Views-UserControls-CardDisplays-CardDisplay-Dispose-System-Boolean- 'mtg_lite.Views.UserControls.CardDisplays.CardDisplay.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-mtg_lite-Views-UserControls-CardDisplays-CardDisplay-InitializeComponent 'mtg_lite.Views.UserControls.CardDisplays.CardDisplay.InitializeComponent')
- [FormGame](#T-mtg_lite-FormGame 'mtg_lite.FormGame')
  - [components](#F-mtg_lite-FormGame-components 'mtg_lite.FormGame.components')
  - [Dispose(disposing)](#M-mtg_lite-FormGame-Dispose-System-Boolean- 'mtg_lite.FormGame.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-mtg_lite-FormGame-InitializeComponent 'mtg_lite.FormGame.InitializeComponent')
- [HandDisplay](#T-mtg_lite-Views-UserControls-ZoneDisplays-HandDisplay 'mtg_lite.Views.UserControls.ZoneDisplays.HandDisplay')
  - [components](#F-mtg_lite-Views-UserControls-ZoneDisplays-HandDisplay-components 'mtg_lite.Views.UserControls.ZoneDisplays.HandDisplay.components')
  - [Dispose(disposing)](#M-mtg_lite-Views-UserControls-ZoneDisplays-HandDisplay-Dispose-System-Boolean- 'mtg_lite.Views.UserControls.ZoneDisplays.HandDisplay.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-mtg_lite-Views-UserControls-ZoneDisplays-HandDisplay-InitializeComponent 'mtg_lite.Views.UserControls.ZoneDisplays.HandDisplay.InitializeComponent')
- [Library](#T-mtg_lite-Models-Zones-Library 'mtg_lite.Models.Zones.Library')
  - [#ctor(cards,player)](#M-mtg_lite-Models-Zones-Library-#ctor-System-Collections-Generic-List{mtg_lite-Models-Cards-Card},mtg_lite-Models-Players-Player- 'mtg_lite.Models.Zones.Library.#ctor(System.Collections.Generic.List{mtg_lite.Models.Cards.Card},mtg_lite.Models.Players.Player)')
  - [TopCard](#P-mtg_lite-Models-Zones-Library-TopCard 'mtg_lite.Models.Zones.Library.TopCard')
  - [Shuffle()](#M-mtg_lite-Models-Zones-Library-Shuffle 'mtg_lite.Models.Zones.Library.Shuffle')
- [LibraryManager](#T-mtg_lite-Models-Zones-LibraryManager 'mtg_lite.Models.Zones.LibraryManager')
  - [CreateList()](#M-mtg_lite-Models-Zones-LibraryManager-CreateList 'mtg_lite.Models.Zones.LibraryManager.CreateList')
- [Mana](#T-MTGO_lite-Models-Manas-Mana 'MTGO_lite.Models.Manas.Mana')
  - [Pay(manaToPay)](#M-MTGO_lite-Models-Manas-Mana-Pay-MTGO_lite-Models-Manas-Mana- 'MTGO_lite.Models.Manas.Mana.Pay(MTGO_lite.Models.Manas.Mana)')
  - [payable(manaToPay)](#M-MTGO_lite-Models-Manas-Mana-payable-MTGO_lite-Models-Manas-Mana- 'MTGO_lite.Models.Manas.Mana.payable(MTGO_lite.Models.Manas.Mana)')
- [ManaColorDisplay](#T-mtg_lite-Views-UserControls-ManaDisplays-ManaColorDisplay 'mtg_lite.Views.UserControls.ManaDisplays.ManaColorDisplay')
  - [components](#F-mtg_lite-Views-UserControls-ManaDisplays-ManaColorDisplay-components 'mtg_lite.Views.UserControls.ManaDisplays.ManaColorDisplay.components')
  - [Dispose(disposing)](#M-mtg_lite-Views-UserControls-ManaDisplays-ManaColorDisplay-Dispose-System-Boolean- 'mtg_lite.Views.UserControls.ManaDisplays.ManaColorDisplay.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-mtg_lite-Views-UserControls-ManaDisplays-ManaColorDisplay-InitializeComponent 'mtg_lite.Views.UserControls.ManaDisplays.ManaColorDisplay.InitializeComponent')
- [ManaPoolDisplay](#T-mtg_lite-Views-UserControls-ManaDisplays-ManaPoolDisplay 'mtg_lite.Views.UserControls.ManaDisplays.ManaPoolDisplay')
  - [components](#F-mtg_lite-Views-UserControls-ManaDisplays-ManaPoolDisplay-components 'mtg_lite.Views.UserControls.ManaDisplays.ManaPoolDisplay.components')
  - [Dispose(disposing)](#M-mtg_lite-Views-UserControls-ManaDisplays-ManaPoolDisplay-Dispose-System-Boolean- 'mtg_lite.Views.UserControls.ManaDisplays.ManaPoolDisplay.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-mtg_lite-Views-UserControls-ManaDisplays-ManaPoolDisplay-InitializeComponent 'mtg_lite.Views.UserControls.ManaDisplays.ManaPoolDisplay.InitializeComponent')
- [Player](#T-mtg_lite-Models-Players-Player 'mtg_lite.Models.Players.Player')
  - [ManaPool](#P-mtg_lite-Models-Players-Player-ManaPool 'mtg_lite.Models.Players.Player.ManaPool')
  - [PlayCard(card)](#M-mtg_lite-Models-Players-Player-PlayCard-mtg_lite-Models-Cards-Card- 'mtg_lite.Models.Players.Player.PlayCard(mtg_lite.Models.Cards.Card)')
- [Program](#T-mtg_lite-Program 'mtg_lite.Program')
  - [Main()](#M-mtg_lite-Program-Main 'mtg_lite.Program.Main')
- [Resource](#T-mtg_lite-Resource 'mtg_lite.Resource')
  - [CardHeight](#P-mtg_lite-Resource-CardHeight 'mtg_lite.Resource.CardHeight')
  - [CardWidth](#P-mtg_lite-Resource-CardWidth 'mtg_lite.Resource.CardWidth')
  - [Culture](#P-mtg_lite-Resource-Culture 'mtg_lite.Resource.Culture')
  - [ResourceManager](#P-mtg_lite-Resource-ResourceManager 'mtg_lite.Resource.ResourceManager')
  - [aegis_turtle](#P-mtg_lite-Resource-aegis_turtle 'mtg_lite.Resource.aegis_turtle')
  - [ageless_guardian](#P-mtg_lite-Resource-ageless_guardian 'mtg_lite.Resource.ageless_guardian')
  - [alpha_myr](#P-mtg_lite-Resource-alpha_myr 'mtg_lite.Resource.alpha_myr')
  - [alpine_grizzly](#P-mtg_lite-Resource-alpine_grizzly 'mtg_lite.Resource.alpine_grizzly')
  - [ancient_brontodon](#P-mtg_lite-Resource-ancient_brontodon 'mtg_lite.Resource.ancient_brontodon')
  - [ancient_crab](#P-mtg_lite-Resource-ancient_crab 'mtg_lite.Resource.ancient_crab')
  - [armored_wolf_rider](#P-mtg_lite-Resource-armored_wolf_rider 'mtg_lite.Resource.armored_wolf_rider')
  - [barony_vampire](#P-mtg_lite-Resource-barony_vampire 'mtg_lite.Resource.barony_vampire')
  - [black_mana](#P-mtg_lite-Resource-black_mana 'mtg_lite.Resource.black_mana')
  - [blightning](#P-mtg_lite-Resource-blightning 'mtg_lite.Resource.blightning')
  - [blue_mana](#P-mtg_lite-Resource-blue_mana 'mtg_lite.Resource.blue_mana')
  - [canyon_minotaur](#P-mtg_lite-Resource-canyon_minotaur 'mtg_lite.Resource.canyon_minotaur')
  - [card_back](#P-mtg_lite-Resource-card_back 'mtg_lite.Resource.card_back')
  - [card_back_dark](#P-mtg_lite-Resource-card_back_dark 'mtg_lite.Resource.card_back_dark')
  - [chain_lightning](#P-mtg_lite-Resource-chain_lightning 'mtg_lite.Resource.chain_lightning')
  - [clone_legion](#P-mtg_lite-Resource-clone_legion 'mtg_lite.Resource.clone_legion')
  - [colorless_mana](#P-mtg_lite-Resource-colorless_mana 'mtg_lite.Resource.colorless_mana')
  - [compulsive_research](#P-mtg_lite-Resource-compulsive_research 'mtg_lite.Resource.compulsive_research')
  - [death_by_dragons](#P-mtg_lite-Resource-death_by_dragons 'mtg_lite.Resource.death_by_dragons')
  - [devilthorn_fox](#P-mtg_lite-Resource-devilthorn_fox 'mtg_lite.Resource.devilthorn_fox')
  - [false_peace](#P-mtg_lite-Resource-false_peace 'mtg_lite.Resource.false_peace')
  - [forest](#P-mtg_lite-Resource-forest 'mtg_lite.Resource.forest')
  - [fusion_elemental](#P-mtg_lite-Resource-fusion_elemental 'mtg_lite.Resource.fusion_elemental')
  - [gaea_s_blessing](#P-mtg_lite-Resource-gaea_s_blessing 'mtg_lite.Resource.gaea_s_blessing')
  - [glimpse_the_unthinkable](#P-mtg_lite-Resource-glimpse_the_unthinkable 'mtg_lite.Resource.glimpse_the_unthinkable')
  - [green_mana](#P-mtg_lite-Resource-green_mana 'mtg_lite.Resource.green_mana')
  - [incriminate](#P-mtg_lite-Resource-incriminate 'mtg_lite.Resource.incriminate')
  - [island](#P-mtg_lite-Resource-island 'mtg_lite.Resource.island')
  - [memnite](#P-mtg_lite-Resource-memnite 'mtg_lite.Resource.memnite')
  - [merfolk_of_the_pearl_trident](#P-mtg_lite-Resource-merfolk_of_the_pearl_trident 'mtg_lite.Resource.merfolk_of_the_pearl_trident')
  - [mountain](#P-mtg_lite-Resource-mountain 'mtg_lite.Resource.mountain')
  - [plains](#P-mtg_lite-Resource-plains 'mtg_lite.Resource.plains')
  - [red_mana](#P-mtg_lite-Resource-red_mana 'mtg_lite.Resource.red_mana')
  - [savannah_lions](#P-mtg_lite-Resource-savannah_lions 'mtg_lite.Resource.savannah_lions')
  - [scathe_zombies](#P-mtg_lite-Resource-scathe_zombies 'mtg_lite.Resource.scathe_zombies')
  - [spinned_karok](#P-mtg_lite-Resource-spinned_karok 'mtg_lite.Resource.spinned_karok')
  - [swamp](#P-mtg_lite-Resource-swamp 'mtg_lite.Resource.swamp')
  - [white_mana](#P-mtg_lite-Resource-white_mana 'mtg_lite.Resource.white_mana')
  - [woolly_thoctar](#P-mtg_lite-Resource-woolly_thoctar 'mtg_lite.Resource.woolly_thoctar')
- [RowOfCardsDisplay](#T-mtg_lite-Views-UserControls-CardDisplays-RowOfCardsDisplay 'mtg_lite.Views.UserControls.CardDisplays.RowOfCardsDisplay')
  - [components](#F-mtg_lite-Views-UserControls-CardDisplays-RowOfCardsDisplay-components 'mtg_lite.Views.UserControls.CardDisplays.RowOfCardsDisplay.components')
  - [Dispose(disposing)](#M-mtg_lite-Views-UserControls-CardDisplays-RowOfCardsDisplay-Dispose-System-Boolean- 'mtg_lite.Views.UserControls.CardDisplays.RowOfCardsDisplay.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-mtg_lite-Views-UserControls-CardDisplays-RowOfCardsDisplay-InitializeComponent 'mtg_lite.Views.UserControls.CardDisplays.RowOfCardsDisplay.InitializeComponent')
- [TopCardZoneDisplay](#T-mtg_lite-Views-UserControls-ZoneDisplays-TopCardZoneDisplay 'mtg_lite.Views.UserControls.ZoneDisplays.TopCardZoneDisplay')
  - [components](#F-mtg_lite-Views-UserControls-ZoneDisplays-TopCardZoneDisplay-components 'mtg_lite.Views.UserControls.ZoneDisplays.TopCardZoneDisplay.components')
  - [Dispose(disposing)](#M-mtg_lite-Views-UserControls-ZoneDisplays-TopCardZoneDisplay-Dispose-System-Boolean- 'mtg_lite.Views.UserControls.ZoneDisplays.TopCardZoneDisplay.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-mtg_lite-Views-UserControls-ZoneDisplays-TopCardZoneDisplay-InitializeComponent 'mtg_lite.Views.UserControls.ZoneDisplays.TopCardZoneDisplay.InitializeComponent')

<a name='T-mtg_lite-ApplicationConfiguration'></a>
## ApplicationConfiguration `type`

##### Namespace

mtg_lite

##### Summary

Bootstrap the application configuration.

<a name='M-mtg_lite-ApplicationConfiguration-Initialize'></a>
### Initialize() `method`

##### Summary

Bootstrap the application as follows:

```
 Application.EnableVisualStyles();
 Application.SetCompatibleTextRenderingDefault(false);
 Application.SetHighDpiMode(HighDpiMode.SystemAware);
```

##### Parameters

This method has no parameters.

<a name='T-mtg_lite-Views-UserControls-ZoneDisplays-BattlefieldDisplay'></a>
## BattlefieldDisplay `type`

##### Namespace

mtg_lite.Views.UserControls.ZoneDisplays

<a name='F-mtg_lite-Views-UserControls-ZoneDisplays-BattlefieldDisplay-components'></a>
### components `constants`

##### Summary

Variable nécessaire au concepteur.

<a name='M-mtg_lite-Views-UserControls-ZoneDisplays-BattlefieldDisplay-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Nettoyage des ressources utilisées.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true si les ressources managées doivent être supprimées ; sinon, false. |

<a name='M-mtg_lite-Views-UserControls-ZoneDisplays-BattlefieldDisplay-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
le contenu de cette méthode avec l'éditeur de code.

##### Parameters

This method has no parameters.

<a name='T-mtg_lite-Models-Zones-BattlefieldManager'></a>
## BattlefieldManager `type`

##### Namespace

mtg_lite.Models.Zones

<a name='M-mtg_lite-Models-Zones-BattlefieldManager-GetCards-System-String-'></a>
### GetCards(handsName) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| handsName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the name of the hand work like the library |

<a name='T-mtg_lite-Views-UserControls-CardDisplays-CardDisplay'></a>
## CardDisplay `type`

##### Namespace

mtg_lite.Views.UserControls.CardDisplays

<a name='F-mtg_lite-Views-UserControls-CardDisplays-CardDisplay-components'></a>
### components `constants`

##### Summary

Variable nécessaire au concepteur.

<a name='M-mtg_lite-Views-UserControls-CardDisplays-CardDisplay-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Nettoyage des ressources utilisées.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true si les ressources managées doivent être supprimées ; sinon, false. |

<a name='M-mtg_lite-Views-UserControls-CardDisplays-CardDisplay-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
le contenu de cette méthode avec l'éditeur de code.

##### Parameters

This method has no parameters.

<a name='T-mtg_lite-FormGame'></a>
## FormGame `type`

##### Namespace

mtg_lite

<a name='F-mtg_lite-FormGame-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-mtg_lite-FormGame-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-mtg_lite-FormGame-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
 the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-mtg_lite-Views-UserControls-ZoneDisplays-HandDisplay'></a>
## HandDisplay `type`

##### Namespace

mtg_lite.Views.UserControls.ZoneDisplays

<a name='F-mtg_lite-Views-UserControls-ZoneDisplays-HandDisplay-components'></a>
### components `constants`

##### Summary

Variable nécessaire au concepteur.

<a name='M-mtg_lite-Views-UserControls-ZoneDisplays-HandDisplay-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Nettoyage des ressources utilisées.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true si les ressources managées doivent être supprimées ; sinon, false. |

<a name='M-mtg_lite-Views-UserControls-ZoneDisplays-HandDisplay-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
le contenu de cette méthode avec l'éditeur de code.

##### Parameters

This method has no parameters.

<a name='T-mtg_lite-Models-Zones-Library'></a>
## Library `type`

##### Namespace

mtg_lite.Models.Zones

<a name='M-mtg_lite-Models-Zones-Library-#ctor-System-Collections-Generic-List{mtg_lite-Models-Cards-Card},mtg_lite-Models-Players-Player-'></a>
### #ctor(cards,player) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cards | [System.Collections.Generic.List{mtg_lite.Models.Cards.Card}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{mtg_lite.Models.Cards.Card}') | the list of card (the Deck) |
| player | [mtg_lite.Models.Players.Player](#T-mtg_lite-Models-Players-Player 'mtg_lite.Models.Players.Player') | the player of this deck |

<a name='P-mtg_lite-Models-Zones-Library-TopCard'></a>
### TopCard `property`

##### Summary

let user not see top card

<a name='M-mtg_lite-Models-Zones-Library-Shuffle'></a>
### Shuffle() `method`

##### Summary



##### Returns

shuffle the card arround and it will return a random card at the top

##### Parameters

This method has no parameters.

<a name='T-mtg_lite-Models-Zones-LibraryManager'></a>
## LibraryManager `type`

##### Namespace

mtg_lite.Models.Zones

<a name='M-mtg_lite-Models-Zones-LibraryManager-CreateList'></a>
### CreateList() `method`

##### Summary

start deck creations

##### Returns

return a list for the deck

##### Parameters

This method has no parameters.

<a name='T-MTGO_lite-Models-Manas-Mana'></a>
## Mana `type`

##### Namespace

MTGO_lite.Models.Manas

<a name='M-MTGO_lite-Models-Manas-Mana-Pay-MTGO_lite-Models-Manas-Mana-'></a>
### Pay(manaToPay) `method`

##### Summary

verify if user can pay for this card

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| manaToPay | [MTGO_lite.Models.Manas.Mana](#T-MTGO_lite-Models-Manas-Mana 'MTGO_lite.Models.Manas.Mana') | the mana to remove from the mana pool |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | tell user he can't pay for this card |

<a name='M-MTGO_lite-Models-Manas-Mana-payable-MTGO_lite-Models-Manas-Mana-'></a>
### payable(manaToPay) `method`

##### Summary

this function check all the mana type the card use

##### Returns

return a true or a false if you can pay to use this card

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| manaToPay | [MTGO_lite.Models.Manas.Mana](#T-MTGO_lite-Models-Manas-Mana 'MTGO_lite.Models.Manas.Mana') | the cost to pay to use this card |

<a name='T-mtg_lite-Views-UserControls-ManaDisplays-ManaColorDisplay'></a>
## ManaColorDisplay `type`

##### Namespace

mtg_lite.Views.UserControls.ManaDisplays

<a name='F-mtg_lite-Views-UserControls-ManaDisplays-ManaColorDisplay-components'></a>
### components `constants`

##### Summary

Variable nécessaire au concepteur.

<a name='M-mtg_lite-Views-UserControls-ManaDisplays-ManaColorDisplay-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Nettoyage des ressources utilisées.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true si les ressources managées doivent être supprimées ; sinon, false. |

<a name='M-mtg_lite-Views-UserControls-ManaDisplays-ManaColorDisplay-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
le contenu de cette méthode avec l'éditeur de code.

##### Parameters

This method has no parameters.

<a name='T-mtg_lite-Views-UserControls-ManaDisplays-ManaPoolDisplay'></a>
## ManaPoolDisplay `type`

##### Namespace

mtg_lite.Views.UserControls.ManaDisplays

<a name='F-mtg_lite-Views-UserControls-ManaDisplays-ManaPoolDisplay-components'></a>
### components `constants`

##### Summary

Variable nécessaire au concepteur.

<a name='M-mtg_lite-Views-UserControls-ManaDisplays-ManaPoolDisplay-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Nettoyage des ressources utilisées.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true si les ressources managées doivent être supprimées ; sinon, false. |

<a name='M-mtg_lite-Views-UserControls-ManaDisplays-ManaPoolDisplay-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
le contenu de cette méthode avec l'éditeur de code.

##### Parameters

This method has no parameters.

<a name='T-mtg_lite-Models-Players-Player'></a>
## Player `type`

##### Namespace

mtg_lite.Models.Players

<a name='P-mtg_lite-Models-Players-Player-ManaPool'></a>
### ManaPool `property`

<a name='M-mtg_lite-Models-Players-Player-PlayCard-mtg_lite-Models-Cards-Card-'></a>
### PlayCard(card) `method`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| card | [mtg_lite.Models.Cards.Card](#T-mtg_lite-Models-Cards-Card 'mtg_lite.Models.Cards.Card') | the card  the player is playing |

<a name='T-mtg_lite-Program'></a>
## Program `type`

##### Namespace

mtg_lite

<a name='M-mtg_lite-Program-Main'></a>
### Main() `method`

##### Summary

The main entry point for the application.

##### Parameters

This method has no parameters.

<a name='T-mtg_lite-Resource'></a>
## Resource `type`

##### Namespace

mtg_lite

##### Summary

Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.

<a name='P-mtg_lite-Resource-CardHeight'></a>
### CardHeight `property`

##### Summary

Recherche une chaîne localisée semblable à 180.

<a name='P-mtg_lite-Resource-CardWidth'></a>
### CardWidth `property`

##### Summary

Recherche une chaîne localisée semblable à 130.

<a name='P-mtg_lite-Resource-Culture'></a>
### Culture `property`

##### Summary

Remplace la propriété CurrentUICulture du thread actuel pour toutes
  les recherches de ressources à l'aide de cette classe de ressource fortement typée.

<a name='P-mtg_lite-Resource-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Retourne l'instance ResourceManager mise en cache utilisée par cette classe.

<a name='P-mtg_lite-Resource-aegis_turtle'></a>
### aegis_turtle `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-ageless_guardian'></a>
### ageless_guardian `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-alpha_myr'></a>
### alpha_myr `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-alpine_grizzly'></a>
### alpine_grizzly `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-ancient_brontodon'></a>
### ancient_brontodon `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-ancient_crab'></a>
### ancient_crab `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-armored_wolf_rider'></a>
### armored_wolf_rider `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-barony_vampire'></a>
### barony_vampire `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-black_mana'></a>
### black_mana `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-blightning'></a>
### blightning `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-blue_mana'></a>
### blue_mana `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-canyon_minotaur'></a>
### canyon_minotaur `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-card_back'></a>
### card_back `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-card_back_dark'></a>
### card_back_dark `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-chain_lightning'></a>
### chain_lightning `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-clone_legion'></a>
### clone_legion `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-colorless_mana'></a>
### colorless_mana `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-compulsive_research'></a>
### compulsive_research `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-death_by_dragons'></a>
### death_by_dragons `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-devilthorn_fox'></a>
### devilthorn_fox `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-false_peace'></a>
### false_peace `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-forest'></a>
### forest `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-fusion_elemental'></a>
### fusion_elemental `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-gaea_s_blessing'></a>
### gaea_s_blessing `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-glimpse_the_unthinkable'></a>
### glimpse_the_unthinkable `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-green_mana'></a>
### green_mana `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-incriminate'></a>
### incriminate `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-island'></a>
### island `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-memnite'></a>
### memnite `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-merfolk_of_the_pearl_trident'></a>
### merfolk_of_the_pearl_trident `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-mountain'></a>
### mountain `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-plains'></a>
### plains `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-red_mana'></a>
### red_mana `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-savannah_lions'></a>
### savannah_lions `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-scathe_zombies'></a>
### scathe_zombies `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-spinned_karok'></a>
### spinned_karok `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-swamp'></a>
### swamp `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-white_mana'></a>
### white_mana `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='P-mtg_lite-Resource-woolly_thoctar'></a>
### woolly_thoctar `property`

##### Summary

Recherche une ressource localisée de type System.Drawing.Bitmap.

<a name='T-mtg_lite-Views-UserControls-CardDisplays-RowOfCardsDisplay'></a>
## RowOfCardsDisplay `type`

##### Namespace

mtg_lite.Views.UserControls.CardDisplays

<a name='F-mtg_lite-Views-UserControls-CardDisplays-RowOfCardsDisplay-components'></a>
### components `constants`

##### Summary

Variable nécessaire au concepteur.

<a name='M-mtg_lite-Views-UserControls-CardDisplays-RowOfCardsDisplay-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Nettoyage des ressources utilisées.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true si les ressources managées doivent être supprimées ; sinon, false. |

<a name='M-mtg_lite-Views-UserControls-CardDisplays-RowOfCardsDisplay-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
le contenu de cette méthode avec l'éditeur de code.

##### Parameters

This method has no parameters.

<a name='T-mtg_lite-Views-UserControls-ZoneDisplays-TopCardZoneDisplay'></a>
## TopCardZoneDisplay `type`

##### Namespace

mtg_lite.Views.UserControls.ZoneDisplays

<a name='F-mtg_lite-Views-UserControls-ZoneDisplays-TopCardZoneDisplay-components'></a>
### components `constants`

##### Summary

Variable nécessaire au concepteur.

<a name='M-mtg_lite-Views-UserControls-ZoneDisplays-TopCardZoneDisplay-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Nettoyage des ressources utilisées.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true si les ressources managées doivent être supprimées ; sinon, false. |

<a name='M-mtg_lite-Views-UserControls-ZoneDisplays-TopCardZoneDisplay-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
le contenu de cette méthode avec l'éditeur de code.

##### Parameters

This method has no parameters.
