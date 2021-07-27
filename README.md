# Pristineness

This repository is a fictive company's [monorepo](https://en.wikipedia.org/wiki/Monorepo) that reflects the current state of my preferences on several technical matters.

## Getting started
Start with the [**welcome folder**](welcome/README.md).

## Folder Structure
Words in `<brackets>` are placeholders for proper nouns chosen by the company owning this monorepo.

```text
repo
|-- CrossScope                                   # code reusable from anywhere in the monorepo (architectural concerns, algorithms, utilities, security, logging, etc.)
    `-- Logging
|-- Domain                                       # domain model + business rules (objects with properties and methods)
    `-- <DomainModule1>
|-- <Application1>                               # application programming interfaces for manipulation of the domain model
    |-- UseCases
        `-- <ApplicationModule1>
            |-- Contract
            |-- Implementation
            `-- Implementation.Dependencies
                |-- Abstractions
                `-- InMemoryImplementations
|-- <Application1>.<Product1> (or <Pro>.<duct1>) # entry point / calls application interfaces / persistance layer implementation / components communication
    |-- <Product1>.sln
    |-- <ApplicationModule1>.Dependencies
    `-- Startup
`-- welcome                                      # help for a tech person that does not master 100% of the project
    |-- contributing                                 # technical culture/school of thought in this project (for instance: sociable-vs-solitary unit testing?)
    |-- contributors                                 # personal readmes (values/how-I-work/how-I-react/what-I-think-of profile pieces of information)
    |-- glossary                                     # technical glossary with references (for instance: broken window, tracing bullet, grok, yagni)
    |-- howtos                                       # technical step-by-step docs for a specific technical issue (for instance: how to create a new csproj/doc file)
    |-- scripts                                      # sharing the command line power! (for instance: deploy on a virtual machine with a default config)
    `-- templates                                    # sharing dotnete templates! (see dotnet new --install doc)
```

Terminology:
* **Domain**: the set of rules that govern businesses in a given domain/industry
* **Application**: the use cases and operation of the system
* **Product**: something that can be deployed and used by a person or a client

| Example           | Domain                 | Application        | Product                   |
| --                | --                     | --                 | --                        |
| Google            | Web page indexing      | the search engine  | the web site              |
| Google Search Bar | --                     | --                 | the Android application\* |
| GitHub            | Git repository hosting | the hosting engine | the web site              |
| GitHub API        | --                     | --                 | the web service           |
| GitHub CLI        | --                     | --                 | the console application\* |

_\* these words, in their specific context, have a different meaning from the **Application** word I'm using in the context of this repository_

