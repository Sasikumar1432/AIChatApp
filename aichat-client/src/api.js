import axios from "axios";

const api = axios.create({
  baseURL: "http://localhost:5123/api",
  headers: {
    "Content-Type": "application/json",
  },
});

export default api;