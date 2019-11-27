(define (reverse l)
  (if (null? l)
     '()
     (append (reverse (cdr l)) (list (car l)))
  )
)
(define (atom? x) (not (or (pair? x) (null? x))))


(define in-order-traverse (lambda (tree)
			    (cond

			     ((atom? tree) (write-to-string tree))
			     (else (string-join (reverse (map in-order-traverse (cdr tree)))))
			     )
			    ))
(define string-join (lambda (strings)
		      (cond
		       ((null? strings) "")
		       (else (string-append (string-join (cdr strings)) (car strings)))
		       )
		      ))
(define jsonify-funcdef (lambda (tree)
			  (cond
			   
			   ((or (eq? tree '()) (null? tree)) "")

			   
			   ((eq? (caar tree) 'declspecifierseq)
			    
			    (string-append (string-append (string-append "type:\"" (in-order-traverse (car tree)))
			    		   "\",\n")
			    		   (jsonify-funcdef (cdr tree))
			    		 )
			    )
			   ((eq? (caar tree) 'declarator)
			    
			    (string-append (string-append (string-append "name:\"" (in-order-traverse (car tree)))
			    		   "\",\n")
			    		   (jsonify-funcdef (cdr tree))
			    		 )
			    )
			   ((eq? (caar tree) 'functionbody)
			    
			    (string-append (string-append (string-append "body: \"" (in-order-traverse (car tree)))
			    		   (jsonify-funcdef (cdr tree)
			    		   
			    		 )
			    ) "\",\n")
			   
			    )
			   (else "err: jsonify-funcdef else clause"
			    )
			  )))

(define jsonify-declaration (lambda (tree)
			  (cond
			   ((eq? (car tree) 'declaration)
			   (jsonify-funcdef (cdr (car (cdr tree)))))
			   )
			  ))
(define jsonify (lambda (tree)
		  (cond
		   
		   ((atom? tree) "")  ;; removed '( ) from input 
		   ((eq? (car tree) 'declaration)
		    (string-append (string-append "{\n" (jsonify-declaration tree)) "}\n,")
		     
		     )
		   
		   ((or (eq? (car tree) 'declarationseq) (eq? (car tree) 'translationunit))
		    (string-join (map jsonify tree))
		     
		      
		    )
		   
		   (else (begin (display "else statement tree:\n") (display tree)))
		   
		  )))

(define writestuff (lambda () (write-string (jsonify (with-input-from-file "tree.scm" read)))))

(with-output-to-file "tree.json" writestuff)


