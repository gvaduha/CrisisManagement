namespace VA.CrisisManagement.Domain

module DomainObjects =

    open System

    /// Types are mocks for modelling domain

    /// Generic person organization cares for i.e. employee or family member
    type Person() =
        member this.Name = "Jerome"
        member this.birthDate = DateTime(1980, 10, 21)

    /// Family or Employee including at least himself (to not introduce Some[T])
    type Family() =
        member this.Members (*: Set<Person>*) = [Person()]

    type Employee() = 
        inherit Person()
        member this.Position = "Engineer"
        member this.Family = fun unit -> Family()

    type Victim() =
        inherit Person()
        member this.Condition = "Severe"


    /// Crisis resistance parties
    type CrisisTeamMember() =
        inherit Employee()
        member this.Role = "Coordinator"

    type Volunteer() =
        member this.Name = "Red cross"
        member this.TreatVictims (*: Set<>*) = [Victim()]


    /// Documents and storages
    type Document() =
        member this.Name = "Evacuation plan"

    type VirtualRoom() =
        member this.Name = "Rescue Team"
        member this.Documents (*: Set<>*) = [Document()]


    /// Crisis plans and tasks
    type TaskState =
        | Approved
        | InProgress
        | Rejected
        | Completed

    type CrisisTask() =
        member this.Name = "Inform all employees"
        member this.State = TaskState.Completed
        member this.AssignedEmployees (*: Set<>*) = [Employee()]
        member this.AssignedVolunteers (*: Set<>*) = [Volunteer()]

    type CrisisManagementPlan() =
        member this.Name = "Plan B"
        member this.Tasks (*: Set<>*) = [CrisisTask()]
        member this.State = TaskState.InProgress


    /// "Central" domain object
    type Incident() =
        member this.Type = "Flood"
        member this.Name = "Indonesia July 2015"
        member this.CrisisTeam (*: Set<>*) = [CrisisTeamMember()]
        member this.CrisisManagementPlans (*: Set<>*) = [CrisisManagementPlan()]
        member this.VirtualRooms (*: Set<>*) = [VirtualRoom()]
        member this.Victims (*: Set<>*) = [Victim()]
        member this.Volunteers (*: Set<>*) = [Volunteer()]


    /// "Root" domain object
    type Organization() =
        member this.Employees (*: Set<>*) = [Employee()]
        member this.Incidents (*: Set<>*) = [Incident()]
