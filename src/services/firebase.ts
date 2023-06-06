import { initializeApp, getApps, getApp } from "firebase/app";
import { getAuth } from "firebase/auth";
import { getFirestore } from "firebase/firestore";

const firebaseConfig = {
  apiKey: "AIzaSyAvUlZDcWk0naNKYQXgAH7gZ2dvWwy7Fgw",
  authDomain: "coinkeeper-9f204.firebaseapp.com",
  projectId: "coinkeeper-9f204",
  storageBucket: "coinkeeper-9f204.appspot.com",
  messagingSenderId: "328255690983",
  appId: "1:328255690983:web:f319ccf704691bb45f6a42",
  measurementId: "G-P3GFDVTRPE"
};

const app = getApps().length ? getApp() : initializeApp(firebaseConfig);

const auth = getAuth(app);
const db = getFirestore(app);

export { auth, db };
