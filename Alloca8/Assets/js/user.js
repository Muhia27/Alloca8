const API_BASE_URL = "http://localhost:5246";

// Fetch hotels from the backend
fetch(`${API_BASE_URL}/api/Hotels`)
    .then(response => response.json())
    .then(data => {
        console.log("Hotels:", data);
    })
    .catch(error => console.error("Error fetching hotels:", error));