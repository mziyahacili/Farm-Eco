# Farm-Eco

## Description

**Farm-Eco** is a system built using a microservices architecture, designed for monitoring and predicting soil and climate conditions in agricultural fields. The system consists of several services, each performing a specific task, from processing data on soil and climate to prediction and providing information to users.

### Key Features:
- Predicting soil conditions based on climate factors.
- Integration with external data sources (weather, soil quality, etc.).
- Microservices architecture with an API Gateway.
- Use of advanced technologies for monitoring and analyzing data.

## Architecture Structure

The project is based on a microservices architecture and includes the following main components:

1. **API Gateway** (Ocelot)
   - The central entry point for all services. It proxies requests from clients to the appropriate microservices (e.g., `AuthAPI`, `SoilAPI`, etc.).

2. **AuthAPI** (Authentication Service)
   - Handles user registration and authentication.

3. **SoilAPI** (Soil Data Service)
   - Processes soil condition data, including moisture, temperature, and other parameters.

4. **ClimateAPI** (Climate Data Service)
   - Processes climate data, including air temperature, precipitation, and humidity.

5. **PredictionAPI** (Prediction Service)
   - Uses predictive algorithms to analyze soil and climate conditions and provide recommendations to farmers for improving soil health and optimizing crop growth.

## Getting Started

### Prerequisites

To run the project locally, you need to have the following installed:
- .NET Core SDK (for backend microservices)
- Docker (for containerizing services)
- Node.js and npm (if working with a frontend)

