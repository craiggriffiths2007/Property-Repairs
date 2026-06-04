EndpointMappings — API endpoint reference

Location: PropertySurveyService/EndpointMappings.cs

Purpose

This file registers the application's minimal API endpoints (via MapPost) that the mobile PDAs and other clients call to send or retrieve survey, vehicle, image and job data. The extension method to add in Program.cs is: app.MapAPIEndpoints();

General behavior

- All endpoints are registered as POST routes.
- Most endpoints accept DTOs (or lists of DTOs) and use AppDBContext to persist data.
- Several endpoints use a "delete-by-Guid then add" strategy to update incoming records: incoming items have Id = 0 before insert; existing rows with the same Guid are removed first using ExecuteDelete().
- /SendVehicleChecks uses Newtonsoft.Json with TypeNameHandling.Auto to support polymorphic deserialization of vehicle check items.
- /GetImage returns a file result (bytes + content-type) for an image record; several image endpoints use base64-encoded image data.

Endpoints

- POST /SendLadderChecks
  - Body: List<LadderCheck>
  - Action: For each LadderCheck: set Id=0, delete existing rows with same Guid, add and save
  - Response: { status: "success" }

- POST /SendToolChecks
  - Body: List<ToolCheck>
  - Action: Same pattern as SendLadderChecks
  - Response: { status: "success" }

- POST /SendSpotChecks
  - Body: List<SpotCheck>
  - Action: Same pattern as SendLadderChecks
  - Response: { status: "success" }

- POST /GetSpotCheckJobInfo
  - Body: GetDataDTO (contains AgentCode and contract_number)
  - Action: Lookup agent by AgentCode; find Job for that agent with matching ContractCode and DiaryDate >= Today; returns JobDTO (job + customer). Returns 400 if agent not found.

- POST /SendMileageSheets
  - Body: List<MileageSheet>
  - Action: Same insert/update pattern
  - Response: { status: "success" }

- POST /SendWorkAccidents
  - Body: List<FAccident>
  - Action: Same insert/update pattern
  - Response: { status: "success" }

- POST /SendVehicleAccidents
  - Body: List<AccidentsVehicleDTO>
  - Action: For each DTO, save Accident header (Id=0, delete by Guid then add), then save related items (whitnesses etc.) with Accident_sheetId set to header Id. Related items are also deleted by Guid before insert.
  - Response: { status: "success" }

- POST /SendVehicleChecks
  - Body: JsonDTO (contains serialized JSON string)
  - Action: Uses Newtonsoft.Json with TypeNameHandling.Auto to deserialize List<VehicleCheckDTO> (polymorphic). For each: save header (Id=0, delete by Guid), then save related vehicle items (DeliveryVans, DeliveryHGVs, FitterVans, SalesCars) with VehicleCheckHeaderId set to header Id; deletes existing by Guid first.
  - Response: { status: "success" }

- POST /GetVehicles
  - Body: GetDataDTO (AgentCode, BranchCode)
  - Action: Validate Agent and Branch, return list of VehicleDTO for branch vehicles. 400 if agent/branch not found.

- POST /GetSurveyJobs
  - Body: GetDataDTO (AgentCode)
  - Action: Returns JobDTO list for jobs where AgentId matches, JobType == Survey, and DiaryDate >= Today.

- POST /GetImage
  - Body: GetDataDTO (AgentCode, Filename)
  - Action: Validates AgentCode. Finds the image record by Filename. If found, decodes Base64 string to bytes (if stored as string) and returns Results.File(bytes, contentType, filename). Content-Type is inferred from file extension (.jpg, .png, .mp4, etc.). Returns 400 if agent not found, 404 if image missing.
  - Note: An older commented alternative returned an ImageDTO with raw bytes.

- POST /GetFittingJobs
  - Body: GetDataDTO (AgentCode)
  - Action: Returns a list of PDAJobDTO constructed from jobs where AgentId matches and JobType > 0. For each job the code assembles a JobHeader, items (survey items) and collects image filenames matching the survey items' contract/item number pattern.

- POST /SendSurveys
  - Body: List<PDAJobDTO>
  - Action: For each PDAJobDTO: save JobHeader (Id=0, delete by Guid then add); then call SaveItems for collections such as Items, Panels, Aluminia, etc. SaveItems sets HeaderId and deletes existing items by Guid before adding.
  - Response: { status: "success" }

- POST /SendFittings
  - Body: List<PDAJobDTO>
  - Action: Saves JobHeader (Id=0) for each job. Minimal additional processing.
  - Response: { status: "success" }

- POST /SendImage
  - Body: ImageDTO (Filename, Data)
  - Action: Attempts to upsert the image record in database (overwrite existing by Filename) and save to disk at D:\PropertySurveyImages (creates directory if needed). Data is expected to be base64 string. Returns OKRecordDTO with comments indicating success or partial failures.

Notes and implementation details

- AppDBContext is injected into each endpoint and used directly for queries and persistence.
- The code frequently uses ExecuteDelete() on IQueryable to remove existing rows by Guid. That requires EF Core 7+ features.
- File-system writes in /SendImage are synchronous and write to a hard-coded path D:\PropertySurveyImages. Adjust if deploying to an environment where that path is unavailable.
- Error handling: endpoints generally return a simple success object. Some endpoints return 400 with a ReasonPhrase when Agent/Branch is not found; /SendImage returns an OKRecordDTO containing comments describing errors.

How to use / call

- Ensure Program.cs calls app.MapAPIEndpoints(); after creating the WebApplication builder and app.
- All endpoints are POST; serialise the body as JSON. For endpoints expecting lists, send JSON arrays.
- For /SendVehicleChecks send a JSON object with property json containing the serialized JSON for the polymorphic list. The server expects TypeNameHandling.Auto for polymorphic types.

Suggested improvements (non-breaking)

- Add endpoint authorization and authentication checks for AgentCode or a token to avoid unauthenticated data writes.
- Replace hard-coded file save path with a configuration value.
- Centralize the "delete-by-guid then add" logic into a helper to reduce duplication.
- Add XML documentation comments on the extension method so IDEs can surface the available endpoint set.

