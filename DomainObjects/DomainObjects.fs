namespace VA.CrisisManagement.Domain

module DomainObjects =

    open System

    /// Types are mocks for modelling domain

    type Persistent() =
        member this.Id = "0001f34eba05"

    /// Generic person organization cares for i.e. employee or family member
    type Person() =
        inherit Persistent()
        member this.Name = "Jerome"
        member this.BirthDate = DateTime(1980, 10, 21)

    /// Family or Employee including at least himself (to not introduce Some[T])
    type Family() =
        inherit Persistent()
        member this.Members (*: Set<Person>*) = [Person()]

    type Employee() = 
        inherit Person()
        member this.Position = "Engineer"
        member this.Family = fun unit -> Family()

    type Victim() =
        inherit Person()
        member this.Condition = "Severe"

    /// Crisis resistance parties communication
    type CommunicationChannel() =
        member this.Address = "ben@channelX"

    /// Crisis resistance parties
    type CrisisTeamMember() =
        inherit Employee()
        member this.Role = "Coordinator"
        member this.CommunicationChannels = [CommunicationChannel()]

    type Volunteer() =
        inherit Persistent()
        member this.Name = "Red cross"
        member this.TreatVictims (*: Set<>*) = [Victim()]


    /// One Artefact umbrella to all types of Artefacts and it's storage VirtualRoom
    type Artefact() =
        inherit Persistent()
        // Meta information section
        member this.Name = "Evacuation plan"
        member this.CreationDate = DateTime.Now

    type VirtualRoom() =
        inherit Persistent()
        member this.Name = "Rescue Team"
        member this.Artefacts (*: Set<>*) = [Artefact()]


    /// Crisis plans and tasks
    type TaskState =
        | Approved
        | InProgress
        | Rejected
        | Completed

    type CrisisTask() =
        inherit Persistent()
        member this.Name = "Inform all employees"
        member this.State = TaskState.Completed
        member this.AssignedEmployees (*: Set<>*) = [Employee()]
        member this.AssignedVolunteers (*: Set<>*) = [Volunteer()]
        member this.Artefacts (*: Set<>*) = [Artefact()]

    type CrisisManagementPlan() =
        inherit Artefact()
        member this.Name = "Plan B"
        member this.Tasks (*: Set<>*) = [CrisisTask()]
        member this.State = TaskState.InProgress


    /// "Central" domain object
    type Crisis() =
        inherit Persistent()
        member this.Type = "Flood"
        member this.Name = "Indonesia July 2015"
        member this.CrisisTeam (*: Set<>*) = [CrisisTeamMember()]
        member this.CrisisManagementPlans (*: Set<>*) = [CrisisManagementPlan()]
        member this.VirtualRooms (*: Set<>*) = [VirtualRoom()]
        member this.Victims (*: Set<>*) = [Victim()]
        member this.Volunteers (*: Set<>*) = [Volunteer()]
        member this.Artefacts (*: Set<>*) = [Artefact()]


    /// "Root" domain object
    type Organization() =
        inherit Persistent()
        member this.Employees (*: Set<>*) = [Employee()]
        member this.Crisises (*: Set<>*) = [Crisis()]



    /// System Internal mail communications
    type MailMessageHeader() =
        inherit Persistent()
        member this.From = CrisisTeamMember()
        member this.To = CrisisTeamMember()
        member this.Timestamp = DateTime.Now
        member this.Subject = "FYI: Crisis"

    type MailMessage() =
        inherit MailMessageHeader()
        member this.Body = "New urgent mail!"

    type MailBox() =
        inherit Artefact()
        member this.Owner = CrisisTeamMember()
        member this.Content = [MailMessage()]


    /// System Internal chat
    type InstantMessage() =
        member this.From = CrisisTeamMember()
        member this.To = CrisisTeamMember()
        member this.Timestamp = DateTime.Now
        member this.Text = "Call me now!"

    type InstantChatChunk() =
        member this.InstantMessages (*: Set<>*) = [InstantMessage()]

    type InstantChat() =
        inherit Artefact()
        member this.CrisisTeamMembers (*: Set<>*) = [CrisisTeamMember()]
        member this.Chunks (*: Set<>*) = [InstantChatChunk()]
        member this.CurrentChunk = InstantChatChunk()
        member this.PostMessage = fun string -> ()

    type InstantChatClient() =
        member this.Chat = InstantChat()
        member this.CrisisTeamMember = CrisisTeamMember()
        member this.Notify = fun () -> ()
