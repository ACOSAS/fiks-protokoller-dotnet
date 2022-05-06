# fiks-protokoller-dotnet

Dette prosjektet inneholder felleskomponenter som kan brukes av alle protokoller under Fiks-Protokoller paraplyen.
Det vil si f.eks. Fiks-Arkiv, Fiks-Politisk-Behandling, Fiks-Matrikkel osv. 

Det leveres som NuGet pakken KS.Fiks.Protokoller.V1 og er tilgjengelig på NuGet.org her.

## Innhold

NuGet pakken inneholder json-schemas og modeller for feilmeldinger brukt av protokollene. Det er også noen hjelpeklasser for å lettere identifisere og sende korrekte feilmeldinger. 

### Meldinger

#### no.ks.fiks.kvittering.serverfeil.v1:
Denne feilmeldingen sendes tilbake til avsender av en melding når noe har gått galt under behandlingen. 

#### no.ks.fiks.kvittering.ugyldigforespørsel.v1:
Sendes tilbake til avsender av en melding når noe er galt med meldingen fra avsender. F.eks. valideringsfeil eller annet som gjør at den ikke kan behandles pga innholdet. 

#### no.ks.fiks.kvittering.ikkefunnet.v1:

Denne feilmeldingen gis tilbake til avsender når avsender har forsøkt å hente noe som ikke finnes. 