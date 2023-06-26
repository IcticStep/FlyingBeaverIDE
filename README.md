# FlyingBeaverIDE
## Overview
An IDE for writing poems in Ukrainian. Can analyze rhythm and rhyme. Technologies: .Net Core, WindowsForms, MongoDB, SyncFusion, NewtonsoftJson. Main functions are covered with unit-tests.

Example of rhythm analyzing:
![rhythm analyzing screenshot](https://github.com/IcticStep/FlyingBeaverIDE/assets/59373161/5721a4a5-72d9-4378-b23d-f7fb68c7be20)

File-menu screenshot:
![file-menu screenshot](https://github.com/IcticStep/FlyingBeaverIDE/assets/59373161/f42edb8f-7d5f-41cb-9065-459abdac6b3b)


## Setting up
1. Clone the project.
2. Get a Syncfusion key for Windows Forms on their [website](https://www.syncfusion.com/winforms-ui-controls).
3. Create a database in MongoDb:
    - Name a database *"FlyingBeaverDb"*.
    - Name a collection *"Accentuations"*.
    - Load a [Json-file](https://drive.google.com/file/d/1h4OWr1dBinBDbhhbqLcGn2A14Sm4L2xn/view?usp=sharing) to a database.   
4. Fill in User Secrets in the projects using your data: 
    - "UI" project:
    ```
      {
      "SyncfusionKey": *Insert your Syncfusion key here*,
      "UserName": *Insert db user name*,
      "UserPassword": *Insert db user password*,
      "ConnectionString": *Insert your db connection string here. Replace a User name and a User Password with placeholder {UserName} and {UserPassword}. Example: "mongodb+srv://{UserName}:{UserPassword}@somecluset.someaddress.mongodb.net/"* 
      }
    ```
    - "RhythmAnalysing.Tests" project
    ```
      {
      "UserName": *Insert db user name*,
      "UserPassword": *Insert db user password*,
      "ConnectionString": *Insert your db connection string here. Replace a User name and a User Password with placeholder {UserName} and {UserPassword}. Example: "mongodb+srv://{UserName}:{UserPassword}@somecluset.someaddress.mongodb.net/"*
      }
    ```
5. Build and run project "UI".

## Technical details
### Achitecture
Solution is splitted in two main folders:
- Helpers - projects used to mine some information for a database.
- Source - main program.

Architecture of sources is based on 4-layers: view, logic, data storage and model. They are implemented in the projects:
- View - *"UI"*.
- Logic - *"Logic"* and projects in the folder "AnalyzingModules".
- Data storage - *"Data storage"*.
- Model - *"Domain*.

Also, there is a *"Design"* project used to utilize windows forms designer only. It's needed due to impossibility to use some smart-tags in .Net Core, so this project is on .Net Framework. Each time *"Design"* is edited, code from *.designer* file should be copied into a corresponding class of UI project.

Projects dependencies scheme:
![projects dependencies scheme](https://github.com/IcticStep/FlyingBeaverIDE/assets/59373161/18c34d9c-a89a-4e35-89b4-8f50a3fe72f2)

### Poem analyzing algorithms
#### Rhythm analyzing
1. Poem is splitted in tokens: poem token, verses tokens, words tokens and syllable tokens.
2. Accentuations from db are used to accentuate word and syllable tokens.
3. If uknown words remains local dictionary is used to set others accentuations.
4. If there are still unknown words stops analyzing and waiting for adding them by user.
5. Setting rhythm by accentuations.

#### Rhyme analyzing
1. Poem is splitted in tokens: poem token, verses tokens, words tokens and syllable tokens.
2. Rhymes are analyzed by finding similar-sounding vowels.
