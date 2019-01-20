package main

import (
	"log"
	"net/http"
)

// use pattern matching for .go files to run both .go files in web folder. In Windows, use PowerShell for this:
// go run $(ls cmd\web\*.go | % {$_.FullName})
func main() {
	mux := http.NewServeMux()
	mux.HandleFunc("/", home)

	fileServer := http.FileServer(http.Dir("./ui/static/"))
	mux.Handle("/static/", http.StripPrefix("/static", fileServer))

	log.Println("Starting server on :4000")
	err := http.ListenAndServe(":4000", mux)
	log.Fatal(err)
}
